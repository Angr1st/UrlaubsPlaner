﻿namespace UrlaubsPlaner
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gp_calendar = new System.Windows.Forms.GroupBox();
            this.listview_event = new System.Windows.Forms.ListView();
            this.MitarbeiterNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gp_input = new System.Windows.Forms.GroupBox();
            this.cbx_employee = new System.Windows.Forms.ComboBox();
            this.cbx_absencetype = new System.Windows.Forms.ComboBox();
            this.employeebtn = new System.Windows.Forms.Button();
            this.absenceTypebtn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label_absencetype = new System.Windows.Forms.Label();
            this.richtextbox_reason = new System.Windows.Forms.RichTextBox();
            this.label_reason = new System.Windows.Forms.Label();
            this.label_employeeNumber = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_firstname = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gp_calendar.SuspendLayout();
            this.gp_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_calendar
            // 
            this.gp_calendar.Controls.Add(this.listview_event);
            this.gp_calendar.Location = new System.Drawing.Point(26, 27);
            this.gp_calendar.Name = "gp_calendar";
            this.gp_calendar.Size = new System.Drawing.Size(433, 880);
            this.gp_calendar.TabIndex = 0;
            this.gp_calendar.TabStop = false;
            this.gp_calendar.Text = "Kalender";
            this.gp_calendar.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // listview_event
            // 
            this.listview_event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr,
            this.MitarbeiterNr,
            this.Vorname,
            this.Nachname,
            this.Typ,
            this.Von,
            this.Bis});
            this.listview_event.FullRowSelect = true;
            this.listview_event.GridLines = true;
            this.listview_event.Location = new System.Drawing.Point(6, 15);
            this.listview_event.MultiSelect = false;
            this.listview_event.Name = "listview_event";
            this.listview_event.Size = new System.Drawing.Size(420, 859);
            this.listview_event.TabIndex = 0;
            this.listview_event.UseCompatibleStateImageBehavior = false;
            this.listview_event.View = System.Windows.Forms.View.Details;
            this.listview_event.SelectedIndexChanged += new System.EventHandler(this.Listview_event_SelectedIndexChanged);
            // 
            // MitarbeiterNr
            // 
            this.MitarbeiterNr.DisplayIndex = 0;
            this.MitarbeiterNr.Text = "MitarbeiterNr";
            // 
            // Vorname
            // 
            this.Vorname.DisplayIndex = 1;
            this.Vorname.Text = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.DisplayIndex = 2;
            this.Nachname.Text = "Nachname";
            // 
            // Typ
            // 
            this.Typ.DisplayIndex = 3;
            this.Typ.Text = "Typ";
            // 
            // Von
            // 
            this.Von.DisplayIndex = 4;
            this.Von.Text = "Von";
            // 
            // Bis
            // 
            this.Bis.DisplayIndex = 5;
            this.Bis.Text = "Bis";
            // 
            // gp_input
            // 
            this.gp_input.Controls.Add(this.lbl_id);
            this.gp_input.Controls.Add(this.txtbx_id);
            this.gp_input.Controls.Add(this.cbx_employee);
            this.gp_input.Controls.Add(this.cbx_absencetype);
            this.gp_input.Controls.Add(this.employeebtn);
            this.gp_input.Controls.Add(this.absenceTypebtn);
            this.gp_input.Controls.Add(this.warningLabel);
            this.gp_input.Controls.Add(this.label_absencetype);
            this.gp_input.Controls.Add(this.richtextbox_reason);
            this.gp_input.Controls.Add(this.label_reason);
            this.gp_input.Controls.Add(this.label_employeeNumber);
            this.gp_input.Controls.Add(this.label_lastname);
            this.gp_input.Controls.Add(this.label_firstname);
            this.gp_input.Controls.Add(this.textbox_lastname);
            this.gp_input.Controls.Add(this.textbox_firstname);
            this.gp_input.Controls.Add(this.button_cancel);
            this.gp_input.Controls.Add(this.button_save);
            this.gp_input.Controls.Add(this.monthCalendar);
            this.gp_input.Location = new System.Drawing.Point(465, 27);
            this.gp_input.Name = "gp_input";
            this.gp_input.Size = new System.Drawing.Size(546, 880);
            this.gp_input.TabIndex = 1;
            this.gp_input.TabStop = false;
            this.gp_input.Text = "Eingabe";
            // 
            // cbx_employee
            // 
            this.cbx_employee.FormattingEnabled = true;
            this.cbx_employee.Location = new System.Drawing.Point(400, 68);
            this.cbx_employee.Name = "cbx_employee";
            this.cbx_employee.Size = new System.Drawing.Size(121, 21);
            this.cbx_employee.TabIndex = 18;
            this.cbx_employee.SelectedValueChanged += new System.EventHandler(this.Cbx_employee_SelectedValueChanged);
            // 
            // cbx_absencetype
            // 
            this.cbx_absencetype.FormattingEnabled = true;
            this.cbx_absencetype.Location = new System.Drawing.Point(400, 99);
            this.cbx_absencetype.Name = "cbx_absencetype";
            this.cbx_absencetype.Size = new System.Drawing.Size(121, 21);
            this.cbx_absencetype.TabIndex = 17;
            // 
            // employeebtn
            // 
            this.employeebtn.Location = new System.Drawing.Point(12, 781);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(92, 23);
            this.employeebtn.TabIndex = 16;
            this.employeebtn.Text = "Mitarbeiter";
            this.employeebtn.UseVisualStyleBackColor = true;
            this.employeebtn.Click += new System.EventHandler(this.Employeebtn_Click);
            // 
            // absenceTypebtn
            // 
            this.absenceTypebtn.Location = new System.Drawing.Point(12, 810);
            this.absenceTypebtn.Name = "absenceTypebtn";
            this.absenceTypebtn.Size = new System.Drawing.Size(92, 35);
            this.absenceTypebtn.TabIndex = 15;
            this.absenceTypebtn.Text = "Abwesenheits Arten";
            this.absenceTypebtn.UseVisualStyleBackColor = true;
            this.absenceTypebtn.Click += new System.EventHandler(this.AbsenceTypebtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(294, 163);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 14;
            // 
            // label_absencetype
            // 
            this.label_absencetype.AutoSize = true;
            this.label_absencetype.Location = new System.Drawing.Point(312, 99);
            this.label_absencetype.Name = "label_absencetype";
            this.label_absencetype.Size = new System.Drawing.Size(28, 13);
            this.label_absencetype.TabIndex = 12;
            this.label_absencetype.Text = "Typ:";
            // 
            // richtextbox_reason
            // 
            this.richtextbox_reason.Location = new System.Drawing.Point(12, 255);
            this.richtextbox_reason.Name = "richtextbox_reason";
            this.richtextbox_reason.Size = new System.Drawing.Size(504, 405);
            this.richtextbox_reason.TabIndex = 11;
            this.richtextbox_reason.Text = "";
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.Location = new System.Drawing.Point(9, 239);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(39, 13);
            this.label_reason.TabIndex = 9;
            this.label_reason.Text = "Grund:";
            this.label_reason.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label_employeeNumber
            // 
            this.label_employeeNumber.AutoSize = true;
            this.label_employeeNumber.Location = new System.Drawing.Point(291, 70);
            this.label_employeeNumber.Name = "label_employeeNumber";
            this.label_employeeNumber.Size = new System.Drawing.Size(73, 13);
            this.label_employeeNumber.TabIndex = 8;
            this.label_employeeNumber.Text = "Mitarbeiter-Nr:";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(302, 44);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(62, 13);
            this.label_lastname.TabIndex = 7;
            this.label_lastname.Text = "Nachname:";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(312, 18);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(52, 13);
            this.label_firstname.TabIndex = 6;
            this.label_firstname.Text = "Vorname:";
            this.label_firstname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Enabled = false;
            this.textbox_lastname.Location = new System.Drawing.Point(400, 41);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(121, 20);
            this.textbox_lastname.TabIndex = 4;
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.Enabled = false;
            this.textbox_firstname.Location = new System.Drawing.Point(400, 15);
            this.textbox_firstname.Name = "textbox_firstname";
            this.textbox_firstname.Size = new System.Drawing.Size(121, 20);
            this.textbox_firstname.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(424, 851);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Beenden";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 851);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 15);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // Nr
            // 
            this.Nr.DisplayIndex = 6;
            this.Nr.Text = "Nr";
            // 
            // txtbx_id
            // 
            this.txtbx_id.Enabled = false;
            this.txtbx_id.Location = new System.Drawing.Point(400, 127);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(121, 20);
            this.txtbx_id.TabIndex = 19;
            this.txtbx_id.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(312, 127);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 20;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 937);
            this.Controls.Add(this.gp_input);
            this.Controls.Add(this.gp_calendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Urlaubsplaner";
            this.Load += new System.EventHandler(this.Form_MainLoad);
            this.gp_calendar.ResumeLayout(false);
            this.gp_input.ResumeLayout(false);
            this.gp_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_calendar;
        private System.Windows.Forms.GroupBox gp_input;
        private System.Windows.Forms.Label label_employeeNumber;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_firstname;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView listview_event;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.RichTextBox richtextbox_reason;
        private System.Windows.Forms.Label label_absencetype;
        private System.Windows.Forms.ColumnHeader MitarbeiterNr;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.ColumnHeader Nachname;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Bis;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button absenceTypebtn;
        private System.Windows.Forms.ComboBox cbx_absencetype;
        private System.Windows.Forms.ComboBox cbx_employee;
        private System.Windows.Forms.ColumnHeader Nr;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbx_id;
    }
}

