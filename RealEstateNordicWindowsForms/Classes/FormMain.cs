using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using RealEstateNordicWindowsForms.Classes;

namespace RealEstateNordicWindowsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           PopulateMunicipalities();
            lstTaxType.SelectedIndex = 0;
            cboSelectDublicate.SelectedIndex = 0;
        }
        
        private void PopulateMunicipalities()//Lists the Municipalities of the Database
        {
            using (SqlConnection connection = new SqlConnection(Connect.connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Municipalities", connection))
            {
                DataTable municipalitiesTable = new DataTable();
                adapter.Fill(municipalitiesTable);
                lstMunicipalities.DisplayMember = "Name";
                lstMunicipalities.ValueMember = "Id";
                lstMunicipalities.DataSource = municipalitiesTable;
            }
        }

        private void lstMunicipalities_SelectedIndexChanged(object sender, EventArgs e)//When Municipalities Change
        {
            taxsearch();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//When Date selected changes
        {
            taxsearch();
        }

        private void taxsearch()
        {
            int municipalitiesId = int.Parse(lstMunicipalities.SelectedValue.ToString());
            DateTime selectedDate = dateTimePickerSearch.Value.Date;
            lstResults.Text = PopulateLists.TaxSearcher(selectedDate, municipalitiesId);
        }

        private void btnAddTax_Click(object sender, EventArgs e)//Add Tax Button
        {
            string SelectedTaxType = lstTaxType.SelectedItem.ToString();                //Sets selected tax type from list
            string taxType = SelectedTaxType.First().ToString();                        //Selects only First letter to make it combatible with DB
            DateTime selectedStartDate = dateTimePickerAddTax.Value.Date;               //Finds selected date
            string taxRate = txtBoxAddNewTax.Text;                                      //Finds entered taxRate
            int municipalityId = int.Parse(lstMunicipalities.SelectedValue.ToString()); //Gets the Id of the selected municipality
            string municipalityName = lstMunicipalities.Text;
            if (ReplaceDublicate.SelectedValue == false)
                MessageBox.Show("Can't add the new tax\n'Replace existing' is set to: 'Ignore All'\nChange to 'Replace All' or 'Always Ask'", "Ignore All Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Validater.TaxRate(taxRate) && ReplaceDublicate.SelectedValue != false)                                              //Validates correct TaxRate
                AddTaxToDb.AddTax(selectedStartDate, taxType, taxRate, municipalityId, municipalityName);     //Sends info to AddTax method
            

            taxsearch();                                                                //Refreshes TaxSearcher
        }

        private void btnImportTax_Click(object sender, EventArgs e)//Import CSV File
        {
            
            OpenFileDialog Ofd = new OpenFileDialog();
            Ofd.Filter = "CSV-Fil (*.csv)|*.csv";//Set type of file to .csv only
            if (Ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)//If we select an actual CSV file and not just closes the window
            {
                
                CSVImporter.Importer(Ofd.FileName);
                taxsearch();

            }
        }

        private void cboSelectDublicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplaceDublicate.replace(cboSelectDublicate.SelectedIndex);
        }

        private void btnReadme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Readme.TextReader(), "Readme");
        }
    }
}
