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
    public class TaxRule
    {
        public int MunicipalityId { get; set; }
        public string MunicipalityName { get; set; }
        public DateTime StartDate { get; set; }
        public string Type { get; set; }
        public string TaxRate { get; set; }
        public bool Error { get; set; }
        
        public TaxRule(string _municipality, string _startDate, string _type, string _taxRate, bool _error)
        {
            Error = _error;
           

            if (!Error)//Checks if there were any errors while sending data to the TaxRule member
            {
                if (Validater.Week(_type) == true)//Check for valid Week Type format
                    Type = _type;
                else
                    Error = true;

                _taxRate = _taxRate.Replace('.', ',');//Replaces . with , to makes it compatible with both

                if (Validater.TaxRate(_taxRate) == true)//Check for valid TaxRate format
                    TaxRate = _taxRate;
                else
                    Error = true;

                MunicipalityName = _municipality;

                if (Validater.StartDate(_startDate) == true)//Check for valid DateTime format
                    StartDate = DateTime.Parse(_startDate);
                else
                    Error = true;

                MunicipalityId = MunicipalityIdGetter(_municipality);//Gets Municipality Id
            }
        }

        private int MunicipalityIdGetter(string _municipality)
        {
            int municipalityId = 0;
            string query = "Select Id FROM Municipalities WHERE Name = @Name";//Gets the Id from the Municipality Name
            using (SqlConnection connection = new SqlConnection(Connect.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", _municipality);

                if (connection.State != ConnectionState.Open)//Checks if connection is open
                {
                    connection.Close();
                    connection.Open();
                }

                try
                {

                    municipalityId = (Int32)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Invalid Municipality '{_municipality}' does not exist in .CSV file", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Error = true;
                }
            }
            return municipalityId;
        }
    }
}
