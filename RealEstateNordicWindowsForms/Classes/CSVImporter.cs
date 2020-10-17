using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateNordicWindowsForms
{
    
    public class CSVImporter
    {
        //Creating a List with TaxRules from CSV File
        public static void Importer(string _filepath)
        {
            
            var taxRuleList = new List<TaxRule>();
            string csvLine;

            using (var sr = new StreamReader(_filepath))
            {
                int line = 0;
                // Read the stream as a string, and write the string to the console.
                while ((csvLine = sr.ReadLine()) != null)
                {
                    line++;
                    TaxRule taxrule = ReadTaxRuleFromCSVLine(csvLine, line);
                    if (!taxrule.Error)//Checks if TaxRule has any Errors before attempting to add it to the List
                    taxRuleList.Add(taxrule);
                }
            }
            bool Continue = true;
            foreach (TaxRule _taxrule in taxRuleList)
            {
               if(!_taxrule.Error)//Makes absolutely sure there are no errors before attempting to add the TaxRule
                {
                    if (!(Continue = AddTaxToDb.AddTax(_taxrule.StartDate, _taxrule.Type, _taxrule.TaxRate, _taxrule.MunicipalityId, _taxrule.MunicipalityName)))//Adds info to DB and break out of foreach loop if method returns false eg. if user selects Cancel in a dublicate warning
                        break;
                }
            }
        }

        //Creating a new TaxRule from csvLine
        public static TaxRule ReadTaxRuleFromCSVLine(string _csvLine, int _line)
        {
            bool error = false;
            string[] parts = _csvLine.Split(';');
            string municipality = "";
            string startDate = "";
            string type = ""; 
            string taxRate= "";

            try
            {
                municipality = parts[0];
                startDate = parts[1];
                type = parts[2];
                taxRate = parts[3];
            }

            catch(Exception ex)
            {
                MessageBox.Show($"{ex.GetType().Name} - Data missing on line: {_line}", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            return new TaxRule(municipality, startDate, type, taxRate, error);
        }
    }
}
