using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateNordicWindowsForms
{
    public class PopulateLists
    {
       
        public static string TaxSearcher(DateTime _selectedDate, int _municipalitiesId)
        {
            SqlConnection connection;

            List<float> TaxTable = new List<float>();

            string query = "SELECT * FROM Taxes WHERE MunicipalityId = @municipalityId AND StartDate <= @selectedDate AND EndDate >= @selectedDate";

            using (connection = new SqlConnection(Connect.connectionString))
            {
                if (connection.State != ConnectionState.Open)//Checks if connection is open
                {
                    connection.Close();
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@municipalityId", _municipalitiesId);//Adds the selected value from lstMunicipalities to @municipalityId
                    command.Parameters.AddWithValue("@selectedDate", _selectedDate);

                    using (SqlDataReader Reader = command.ExecuteReader())
                    {

                        double tax = GetTax(Reader);

                        if (tax != 0)//If Taxes is found
                        {
                            return tax.ToString();
                        }

                        else //If no Taxes is found
                        {

                            return "No Taxrule Exist";
                        }
                    }
                }
            }
        }

        private static double GetTax(SqlDataReader reader)
        {
            double[] Taxes = new double[4];
            double tax = 0;

            while (reader.Read())
            {
                string Type = (string)reader.GetValue(3);
                switch (Type)
                {
                    case "D":
                        Taxes[0] = (double)reader.GetValue(4);
                        break;
                    case "W":
                        Taxes[1] = (double)reader.GetValue(4);
                        break;
                    case "M":
                        Taxes[2] = (double)reader.GetValue(4);
                        break;
                    case "Y":
                        Taxes[3] = (double)reader.GetValue(4);
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < Taxes.Length; i++)
            {
                if (Taxes[i] > 0)
                {
                    tax = Taxes[i];
                    break;
                }
            }

            return tax;
        }
    }
}
