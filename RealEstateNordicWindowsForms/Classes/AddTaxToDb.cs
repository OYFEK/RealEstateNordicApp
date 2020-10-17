using RealEstateNordicWindowsForms.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateNordicWindowsForms
{
    public class AddTaxToDb
    {

     
        public static bool AddTax(DateTime _selectedStartDate, string _taxType, string _taxrate, int _municipalityId, string _municipalityName)
        {
            
            int? dublicateId = null;
            string taxrate = _taxrate.Replace(".", ",");//Makes it possible to use both , and .
            

            if (!double.TryParse(taxrate, NumberStyles.Any, new CultureInfo("da-DK"), out double taxRateInt))//Sets the culture to danish to make sure it converts ,
                MessageBox.Show("Please select a valid number", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DateTime[] Dates = SetStartDateFromTaxType(_taxType, _selectedStartDate);//Makes sure the dates are correct for week, month and year
            DateTime selectedStartDate = Dates[0];
            DateTime selectedEndDate = Dates[1];

            string queryDublicate = "SELECT Id FROM Taxes WHERE StartDate = @StartDate AND Type = @Type AND MunicipalityId = @MunicipalityId";//Checks for dublicates
            using (SqlConnection connection = new SqlConnection(Connect.connectionString))
            {
                SqlCommand command = new SqlCommand(queryDublicate, connection);
                connection.Open();
                command.Parameters.AddWithValue("@StartDate", selectedStartDate);
                command.Parameters.AddWithValue("@Type", _taxType);
                command.Parameters.AddWithValue("@MunicipalityId", _municipalityId);

                try
                {
                    dublicateId = int.Parse(command.ExecuteScalar().ToString());
                }
                catch
                {
                    dublicateId = null;
                }
                

                if (dublicateId != null)//If there is a dublicate in the DB
                {
                    string _date = selectedStartDate.Day.ToString() + "-" + selectedStartDate.Month.ToString() + "-" + selectedStartDate.Year.ToString();//Needs to be updated now to show 00:00:00
                    DialogResult? result = null;
                    if (ReplaceDublicate.SelectedValue == null)//If user has selected to be asked to replace dublicates
                    {
                        string message = $"Dublicate detected in {_municipalityName} on {_date}\nWould you like to replace it?";
                        string title = "Confirm Add";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                        result = MessageBox.Show(message, title, buttons);
                    }
                   

                    if (result == DialogResult.Yes || ReplaceDublicate.SelectedValue == true)//Replaces the TaxValue with the new one
                    {
                        string queryReplace = $"UPDATE Taxes SET Value = @Value WHERE Id = @Id";
                        SqlCommand replaceCommand = new SqlCommand(queryReplace, connection);
                        replaceCommand.Parameters.AddWithValue("@Value", taxRateInt);
                        replaceCommand.Parameters.AddWithValue("@Id", dublicateId);
                        
                        replaceCommand.ExecuteScalar();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else//If there is no dublicate in the DB
                {
  
                    //Adds new entry
                    string query = "INSERT INTO Taxes VALUES(@StartDate, @EndDate, @Type, @Value, @MunicipalityId)";
                    using (SqlCommand newCommand = new SqlCommand(query, connection))
                    {
                        if (connection.State != ConnectionState.Open)//Checks if connection is open
                        {
                            connection.Close();
                            connection.Open();
                        }


                        newCommand.Parameters.AddWithValue("@StartDate", selectedStartDate);
                        newCommand.Parameters.AddWithValue("@EndDate", selectedEndDate);
                        newCommand.Parameters.AddWithValue("@Type", _taxType);
                        newCommand.Parameters.AddWithValue("@Value", taxRateInt);
                        newCommand.Parameters.AddWithValue("@MunicipalityId", _municipalityId);

                        newCommand.ExecuteScalar();
                    }
                }
            }
            return true;
        }

        private static DateTime[] SetStartDateFromTaxType(string _taxType, DateTime _selectedStartDate)//Sets start- and EndDate depending on type of TaxRule.
        {
            DateTime selectedEndDate = DateTime.Now;
            DateTime selectedStartDate = DateTime.Now;
            switch (_taxType)
            {
                case "D"://Day set StartDate and EndDate to the same value
                    selectedEndDate = _selectedStartDate;
                    selectedStartDate = _selectedStartDate;

                    break;
                case "W"://Week - Makes sure StartDate is = Monday and EndDate = Sunday, so the user can add a week by selecting any day of that week
                    string Day = _selectedStartDate.DayOfWeek.ToString();
                    switch (Day)
                    {
                        case "Monday":
                            break;
                        case "Tuesday":
                            selectedStartDate = _selectedStartDate.AddDays(-1);
                            break;
                        case "Wednesday":
                            selectedStartDate = _selectedStartDate.AddDays(-2);
                            break;
                        case "Thursday":
                            selectedStartDate = _selectedStartDate.AddDays(-3);
                            break;
                        case "Friday":
                            selectedStartDate = _selectedStartDate.AddDays(-4);
                            break;
                        case "Saturday":
                            selectedStartDate = _selectedStartDate.AddDays(-5);
                            break;
                        case "Sunday":
                            selectedStartDate = _selectedStartDate.AddDays(-6);
                            break;
                        default:
                            break;
                    }
                    selectedEndDate = selectedStartDate.AddDays(6);
                    break;

                case "M"://Month - Makes sure StartDate is = first day of the month and EndDate = last day of the month, so the user can add a month by selecting any day of that month
                    selectedStartDate = new DateTime(_selectedStartDate.Year, _selectedStartDate.Month, 1);
                    selectedEndDate = selectedStartDate.AddMonths(1).AddDays(-1);
                    break;
                case "Y"://Month - Makes sure StartDate is = first day of the year and EndDate = last day of the year, so the user can add a year by selecting any day of that year
                    selectedStartDate = new DateTime(_selectedStartDate.Year, 1, 1);
                    selectedEndDate = selectedStartDate.AddYears(1).AddDays(-1);
                    break;
                default:
                    break;
            }

            DateTime[] Date = { selectedStartDate, selectedEndDate };
            return Date;
        }
    }
}
