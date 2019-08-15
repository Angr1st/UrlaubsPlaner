namespace UrlaubsPlaner
{
    partial class Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Form));
            this.cancelbtn = new System.Windows.Forms.Button();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.employeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbx_firstname = new System.Windows.Forms.TextBox();
            this.txtbx_lastname = new System.Windows.Forms.TextBox();
            this.dtm_birthday = new System.Windows.Forms.DateTimePicker();
            this.txtbx_street = new System.Windows.Forms.TextBox();
            this.txtbx_housenumber = new System.Windows.Forms.TextBox();
            this.txtbx_postalcode = new System.Windows.Forms.TextBox();
            this.txtbx_city = new System.Windows.Forms.TextBox();
            this.txtbx_telefonnumber = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_housenumber = new System.Windows.Forms.Label();
            this.lbl_postalcode = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_telefonnumber = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cbx_country = new System.Windows.Forms.ComboBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.txtbx_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(672, 405);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 0;
            this.cancelbtn.Text = "Abbrechen";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeID,
            this.employeeNr,
            this.countryCode,
            this.firstName,
            this.lastName,
            this.email});
            this.employeeListView.FullRowSelect = true;
            this.employeeListView.Location = new System.Drawing.Point(13, 13);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(390, 425);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.EmployeeListView_SelectedIndexChanged);
            // 
            // employeeID
            // 
            this.employeeID.Text = "ID";
            // 
            // employeeNr
            // 
            this.employeeNr.Text = "Nr";
            // 
            // countryCode
            // 
            this.countryCode.Text = "Country Code";
            this.countryCode.Width = 77;
            // 
            // firstName
            // 
            this.firstName.Text = "Firstname";
            // 
            // lastName
            // 
            this.lastName.Text = "Lastname";
            // 
            // email
            // 
            this.email.Text = "E-Mail";
            // 
            // txtbx_firstname
            // 
            this.txtbx_firstname.Location = new System.Drawing.Point(588, 24);
            this.txtbx_firstname.Name = "txtbx_firstname";
            this.txtbx_firstname.Size = new System.Drawing.Size(170, 20);
            this.txtbx_firstname.TabIndex = 2;
            // 
            // txtbx_lastname
            // 
            this.txtbx_lastname.Location = new System.Drawing.Point(588, 50);
            this.txtbx_lastname.Name = "txtbx_lastname";
            this.txtbx_lastname.Size = new System.Drawing.Size(170, 20);
            this.txtbx_lastname.TabIndex = 3;
            // 
            // dtm_birthday
            // 
            this.dtm_birthday.Location = new System.Drawing.Point(588, 76);
            this.dtm_birthday.MinDate = new System.DateTime(1903, 1, 2, 0, 0, 0, 0);
            this.dtm_birthday.Name = "dtm_birthday";
            this.dtm_birthday.Size = new System.Drawing.Size(200, 20);
            this.dtm_birthday.TabIndex = 4;
            // 
            // txtbx_street
            // 
            this.txtbx_street.Location = new System.Drawing.Point(588, 103);
            this.txtbx_street.Name = "txtbx_street";
            this.txtbx_street.Size = new System.Drawing.Size(170, 20);
            this.txtbx_street.TabIndex = 5;
            // 
            // txtbx_housenumber
            // 
            this.txtbx_housenumber.Location = new System.Drawing.Point(588, 129);
            this.txtbx_housenumber.Name = "txtbx_housenumber";
            this.txtbx_housenumber.Size = new System.Drawing.Size(170, 20);
            this.txtbx_housenumber.TabIndex = 6;
            // 
            // txtbx_postalcode
            // 
            this.txtbx_postalcode.Location = new System.Drawing.Point(588, 155);
            this.txtbx_postalcode.Name = "txtbx_postalcode";
            this.txtbx_postalcode.Size = new System.Drawing.Size(170, 20);
            this.txtbx_postalcode.TabIndex = 7;
            // 
            // txtbx_city
            // 
            this.txtbx_city.Location = new System.Drawing.Point(588, 181);
            this.txtbx_city.Name = "txtbx_city";
            this.txtbx_city.Size = new System.Drawing.Size(170, 20);
            this.txtbx_city.TabIndex = 8;
            // 
            // txtbx_telefonnumber
            // 
            this.txtbx_telefonnumber.Location = new System.Drawing.Point(588, 207);
            this.txtbx_telefonnumber.Name = "txtbx_telefonnumber";
            this.txtbx_telefonnumber.Size = new System.Drawing.Size(170, 20);
            this.txtbx_telefonnumber.TabIndex = 9;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(410, 24);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(49, 13);
            this.lbl_firstname.TabIndex = 10;
            this.lbl_firstname.Text = "Vorname";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(410, 50);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(59, 13);
            this.lbl_lastname.TabIndex = 11;
            this.lbl_lastname.Text = "Nachname";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(410, 76);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(76, 13);
            this.lbl_birthday.TabIndex = 12;
            this.lbl_birthday.Text = "Gerburtsdatum";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(409, 103);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(42, 13);
            this.lbl_street.TabIndex = 13;
            this.lbl_street.Text = "Strasse";
            // 
            // lbl_housenumber
            // 
            this.lbl_housenumber.AutoSize = true;
            this.lbl_housenumber.Location = new System.Drawing.Point(409, 129);
            this.lbl_housenumber.Name = "lbl_housenumber";
            this.lbl_housenumber.Size = new System.Drawing.Size(69, 13);
            this.lbl_housenumber.TabIndex = 14;
            this.lbl_housenumber.Text = "Hausnummer";
            // 
            // lbl_postalcode
            // 
            this.lbl_postalcode.AutoSize = true;
            this.lbl_postalcode.Location = new System.Drawing.Point(409, 155);
            this.lbl_postalcode.Name = "lbl_postalcode";
            this.lbl_postalcode.Size = new System.Drawing.Size(27, 13);
            this.lbl_postalcode.TabIndex = 15;
            this.lbl_postalcode.Text = "PLZ";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(409, 181);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(32, 13);
            this.lbl_city.TabIndex = 16;
            this.lbl_city.Text = "Stadt";
            // 
            // lbl_telefonnumber
            // 
            this.lbl_telefonnumber.AutoSize = true;
            this.lbl_telefonnumber.Location = new System.Drawing.Point(409, 207);
            this.lbl_telefonnumber.Name = "lbl_telefonnumber";
            this.lbl_telefonnumber.Size = new System.Drawing.Size(80, 13);
            this.lbl_telefonnumber.TabIndex = 17;
            this.lbl_telefonnumber.Text = "Telefonnummer";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(588, 233);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(170, 20);
            this.txtbx_email.TabIndex = 18;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(410, 233);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 13);
            this.lbl_email.TabIndex = 19;
            this.lbl_email.Text = "E-Mail";
            // 
            // cbx_country
            // 
            this.cbx_country.FormattingEnabled = true;
            this.cbx_country.Location = new System.Drawing.Point(588, 260);
            this.cbx_country.Name = "cbx_country";
            this.cbx_country.Size = new System.Drawing.Size(170, 21);
            this.cbx_country.TabIndex = 20;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(410, 263);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(31, 13);
            this.lbl_country.TabIndex = 21;
            this.lbl_country.Text = "Land";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(515, 405);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "Erstellen";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(414, 405);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Leeren";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // txtbx_id
            // 
            this.txtbx_id.Enabled = false;
            this.txtbx_id.Location = new System.Drawing.Point(588, 287);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(170, 20);
            this.txtbx_id.TabIndex = 24;
            this.txtbx_id.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(410, 287);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 25;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(409, 314);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(21, 13);
            this.lbl_number.TabIndex = 26;
            this.lbl_number.Text = "Nr.";
            this.lbl_number.Visible = false;
            // 
            // txtbx_number
            // 
            this.txtbx_number.Enabled = false;
            this.txtbx_number.Location = new System.Drawing.Point(588, 314);
            this.txtbx_number.Name = "txtbx_number";
            this.txtbx_number.Size = new System.Drawing.Size(170, 20);
            this.txtbx_number.TabIndex = 27;
            this.txtbx_number.Visible = false;
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_number);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.cbx_country);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.lbl_telefonnumber);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_postalcode);
            this.Controls.Add(this.lbl_housenumber);
            this.Controls.Add(this.lbl_street);
            this.Controls.Add(this.lbl_birthday);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txtbx_telefonnumber);
            this.Controls.Add(this.txtbx_city);
            this.Controls.Add(this.txtbx_postalcode);
            this.Controls.Add(this.txtbx_housenumber);
            this.Controls.Add(this.txtbx_street);
            this.Controls.Add(this.dtm_birthday);
            this.Controls.Add(this.txtbx_lastname);
            this.Controls.Add(this.txtbx_firstname);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.cancelbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.ColumnHeader employeeNr;
        private System.Windows.Forms.ColumnHeader countryCode;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.TextBox txtbx_firstname;
        private System.Windows.Forms.TextBox txtbx_lastname;
        private System.Windows.Forms.DateTimePicker dtm_birthday;
        private System.Windows.Forms.TextBox txtbx_street;
        private System.Windows.Forms.TextBox txtbx_housenumber;
        private System.Windows.Forms.TextBox txtbx_postalcode;
        private System.Windows.Forms.TextBox txtbx_city;
        private System.Windows.Forms.TextBox txtbx_telefonnumber;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_housenumber;
        private System.Windows.Forms.Label lbl_postalcode;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_telefonnumber;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cbx_country;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox txtbx_number;
    }
}