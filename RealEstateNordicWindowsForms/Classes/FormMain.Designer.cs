namespace RealEstateNordicWindowsForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMunicipalities = new System.Windows.Forms.ListBox();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTax = new System.Windows.Forms.Button();
            this.txtBoxAddNewTax = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSeeTax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerAddTax = new System.Windows.Forms.DateTimePicker();
            this.lblEnterTax = new System.Windows.Forms.Label();
            this.lstTaxType = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImportTax = new System.Windows.Forms.Button();
            this.cboSelectDublicate = new System.Windows.Forms.ComboBox();
            this.lblDublicate = new System.Windows.Forms.Label();
            this.btnReadme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMunicipalities
            // 
            this.lstMunicipalities.FormattingEnabled = true;
            this.lstMunicipalities.Location = new System.Drawing.Point(12, 71);
            this.lstMunicipalities.Name = "lstMunicipalities";
            this.lstMunicipalities.Size = new System.Drawing.Size(172, 186);
            this.lstMunicipalities.Sorted = true;
            this.lstMunicipalities.TabIndex = 0;
            this.lstMunicipalities.SelectedIndexChanged += new System.EventHandler(this.lstMunicipalities_SelectedIndexChanged);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(12, 286);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerSearch.TabIndex = 8;
            this.dateTimePickerSearch.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Municipality";
            // 
            // btnAddTax
            // 
            this.btnAddTax.Location = new System.Drawing.Point(408, 367);
            this.btnAddTax.Name = "btnAddTax";
            this.btnAddTax.Size = new System.Drawing.Size(172, 31);
            this.btnAddTax.TabIndex = 10;
            this.btnAddTax.Text = "Add New Tax";
            this.btnAddTax.UseVisualStyleBackColor = true;
            this.btnAddTax.Click += new System.EventHandler(this.btnAddTax_Click);
            // 
            // txtBoxAddNewTax
            // 
            this.txtBoxAddNewTax.Location = new System.Drawing.Point(408, 341);
            this.txtBoxAddNewTax.Name = "txtBoxAddNewTax";
            this.txtBoxAddNewTax.Size = new System.Drawing.Size(172, 20);
            this.txtBoxAddNewTax.TabIndex = 11;
            // 
            // lstResults
            // 
            this.lstResults.Location = new System.Drawing.Point(12, 341);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(172, 20);
            this.lstResults.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tax";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 270);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Select Date";
            // 
            // lblSeeTax
            // 
            this.lblSeeTax.AutoSize = true;
            this.lblSeeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeTax.Location = new System.Drawing.Point(6, 9);
            this.lblSeeTax.Name = "lblSeeTax";
            this.lblSeeTax.Size = new System.Drawing.Size(142, 31);
            this.lblSeeTax.TabIndex = 15;
            this.lblSeeTax.Text = "Show Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add Tax";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select Start Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerAddTax
            // 
            this.dateTimePickerAddTax.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerAddTax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAddTax.Location = new System.Drawing.Point(408, 286);
            this.dateTimePickerAddTax.Name = "dateTimePickerAddTax";
            this.dateTimePickerAddTax.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerAddTax.TabIndex = 17;
            // 
            // lblEnterTax
            // 
            this.lblEnterTax.AutoSize = true;
            this.lblEnterTax.Location = new System.Drawing.Point(527, 325);
            this.lblEnterTax.Name = "lblEnterTax";
            this.lblEnterTax.Size = new System.Drawing.Size(53, 13);
            this.lblEnterTax.TabIndex = 19;
            this.lblEnterTax.Text = "Enter Tax";
            // 
            // lstTaxType
            // 
            this.lstTaxType.FormattingEnabled = true;
            this.lstTaxType.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year"});
            this.lstTaxType.Location = new System.Drawing.Point(408, 71);
            this.lstTaxType.Name = "lstTaxType";
            this.lstTaxType.Size = new System.Drawing.Size(172, 186);
            this.lstTaxType.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(495, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Tax Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnImportTax
            // 
            this.btnImportTax.Location = new System.Drawing.Point(12, 367);
            this.btnImportTax.Name = "btnImportTax";
            this.btnImportTax.Size = new System.Drawing.Size(172, 31);
            this.btnImportTax.TabIndex = 22;
            this.btnImportTax.Text = "Import Tax from .CSV";
            this.btnImportTax.UseVisualStyleBackColor = true;
            this.btnImportTax.Click += new System.EventHandler(this.btnImportTax_Click);
            // 
            // cboSelectDublicate
            // 
            this.cboSelectDublicate.FormattingEnabled = true;
            this.cboSelectDublicate.Items.AddRange(new object[] {
            "Always Ask",
            "Replace All",
            "Ignore All"});
            this.cboSelectDublicate.Location = new System.Drawing.Point(209, 340);
            this.cboSelectDublicate.Name = "cboSelectDublicate";
            this.cboSelectDublicate.Size = new System.Drawing.Size(172, 21);
            this.cboSelectDublicate.TabIndex = 23;
            this.cboSelectDublicate.SelectedIndexChanged += new System.EventHandler(this.cboSelectDublicate_SelectedIndexChanged);
            // 
            // lblDublicate
            // 
            this.lblDublicate.AutoSize = true;
            this.lblDublicate.Location = new System.Drawing.Point(206, 325);
            this.lblDublicate.Name = "lblDublicate";
            this.lblDublicate.Size = new System.Drawing.Size(86, 13);
            this.lblDublicate.TabIndex = 24;
            this.lblDublicate.Text = "Replace Existing";
            // 
            // btnReadme
            // 
            this.btnReadme.Location = new System.Drawing.Point(209, 367);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(172, 31);
            this.btnReadme.TabIndex = 25;
            this.btnReadme.Text = "Readme";
            this.btnReadme.UseVisualStyleBackColor = true;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 418);
            this.Controls.Add(this.btnReadme);
            this.Controls.Add(this.lblDublicate);
            this.Controls.Add(this.cboSelectDublicate);
            this.Controls.Add(this.btnImportTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTaxType);
            this.Controls.Add(this.lblEnterTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAddTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSeeTax);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtBoxAddNewTax);
            this.Controls.Add(this.btnAddTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.lstMunicipalities);
            this.Name = "FormMain";
            this.Text = "RealEstateNordic";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMunicipalities;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTax;
        private System.Windows.Forms.TextBox txtBoxAddNewTax;
        private System.Windows.Forms.TextBox lstResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSeeTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddTax;
        private System.Windows.Forms.Label lblEnterTax;
        private System.Windows.Forms.ListBox lstTaxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImportTax;
        private System.Windows.Forms.ComboBox cboSelectDublicate;
        private System.Windows.Forms.Label lblDublicate;
        private System.Windows.Forms.Button btnReadme;
    }
}

