using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateNordicWindowsForms
{
    public class Validater
    {
        public static bool Week(string _type)//Validates the Week type
        {
            if (_type == "D" || _type == "W" || _type == "M" || _type == "Y")
                return true;
            else
            {
                MessageBox.Show($"Invalid Type '{_type}' in .CSV file", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }

        public static bool TaxRate(string _taxRate)
        {
            if (double.TryParse(_taxRate, NumberStyles.Any, new CultureInfo("da-DK"), out double testTaxRate))
            {
                if (testTaxRate >= 0 && testTaxRate <= 100)//Ensures that Taxrate is between 0 and 100
                    return true;
                else
                {
                    MessageBox.Show($"Invalid TaxRate '{_taxRate}' in .CSV file, must be between 0 and 100", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid TaxRate Format, must be a numeric value", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool StartDate(string _startDate)
        {
            if (!DateTime.TryParse(_startDate, out DateTime startdate))//Tries to Parse The date to DateTime
            {
                MessageBox.Show($"Invalid Date Format '{_startDate}' in .CSV file", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
