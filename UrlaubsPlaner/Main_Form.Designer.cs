namespace UrlaubsPlaner
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.gp_calendar = new System.Windows.Forms.GroupBox();
            this.listview_event = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gp_input = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.cbx_employee = new System.Windows.Forms.ComboBox();
            this.cbx_absencetype = new System.Windows.Forms.ComboBox();
            this.employeebtn = new System.Windows.Forms.Button();
            this.absenceTypebtn = new System.Windows.Forms.Button();
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
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
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
            // 
            // listview_event
            // 
            this.listview_event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nr,
            this.Vorname,
            this.Nachname,
            this.Typ,
            this.Von,
            this.Bis});
            this.listview_event.FullRowSelect = true;
            this.listview_event.Location = new System.Drawing.Point(6, 15);
            this.listview_event.MultiSelect = false;
            this.listview_event.Name = "listview_event";
            this.listview_event.Size = new System.Drawing.Size(420, 859);
            this.listview_event.TabIndex = 0;
            this.listview_event.UseCompatibleStateImageBehavior = false;
            this.listview_event.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.DisplayIndex = 6;
            this.Id.Text = "Id";
            this.Id.Width = 80;
            // 
            // Nr
            // 
            this.Nr.DisplayIndex = 0;
            this.Nr.Text = "Nr";
            this.Nr.Width = 36;
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
            this.gp_input.Controls.Add(this.dtp_to);
            this.gp_input.Controls.Add(this.dtp_from);
            this.gp_input.Controls.Add(this.lbl_to);
            this.gp_input.Controls.Add(this.lbl_from);
            this.gp_input.Controls.Add(this.btn_clear);
            this.gp_input.Controls.Add(this.lbl_id);
            this.gp_input.Controls.Add(this.txtbx_id);
            this.gp_input.Controls.Add(this.cbx_employee);
            this.gp_input.Controls.Add(this.cbx_absencetype);
            this.gp_input.Controls.Add(this.employeebtn);
            this.gp_input.Controls.Add(this.absenceTypebtn);
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
            this.gp_input.Location = new System.Drawing.Point(465, 27);
            this.gp_input.Name = "gp_input";
            this.gp_input.Size = new System.Drawing.Size(546, 880);
            this.gp_input.TabIndex = 1;
            this.gp_input.TabStop = false;
            this.gp_input.Text = "Eingabe";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(131, 851);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Leeren";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(65, 185);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 20;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // txtbx_id
            // 
            this.txtbx_id.Enabled = false;
            this.txtbx_id.Location = new System.Drawing.Point(331, 185);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(121, 20);
            this.txtbx_id.TabIndex = 19;
            this.txtbx_id.Visible = false;
            // 
            // cbx_employee
            // 
            this.cbx_employee.FormattingEnabled = true;
            this.cbx_employee.Location = new System.Drawing.Point(331, 69);
            this.cbx_employee.Name = "cbx_employee";
            this.cbx_employee.Size = new System.Drawing.Size(121, 21);
            this.cbx_employee.TabIndex = 18;
            this.cbx_employee.SelectedValueChanged += new System.EventHandler(this.Cbx_employee_SelectedValueChanged);
            // 
            // cbx_absencetype
            // 
            this.cbx_absencetype.FormattingEnabled = true;
            this.cbx_absencetype.Location = new System.Drawing.Point(331, 100);
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
            // label_absencetype
            // 
            this.label_absencetype.AutoSize = true;
            this.label_absencetype.Location = new System.Drawing.Point(65, 100);
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
            // 
            // label_employeeNumber
            // 
            this.label_employeeNumber.AutoSize = true;
            this.label_employeeNumber.Location = new System.Drawing.Point(44, 71);
            this.label_employeeNumber.Name = "label_employeeNumber";
            this.label_employeeNumber.Size = new System.Drawing.Size(73, 13);
            this.label_employeeNumber.TabIndex = 8;
            this.label_employeeNumber.Text = "Mitarbeiter-Nr:";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(55, 45);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(62, 13);
            this.label_lastname.TabIndex = 7;
            this.label_lastname.Text = "Nachname:";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(65, 19);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(52, 13);
            this.label_firstname.TabIndex = 6;
            this.label_firstname.Text = "Vorname:";
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Enabled = false;
            this.textbox_lastname.Location = new System.Drawing.Point(331, 42);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(121, 20);
            this.textbox_lastname.TabIndex = 4;
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.Enabled = false;
            this.textbox_firstname.Location = new System.Drawing.Point(331, 16);
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
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(68, 131);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(29, 13);
            this.lbl_from.TabIndex = 22;
            this.lbl_from.Text = "Von:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(68, 155);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(24, 13);
            this.lbl_to.TabIndex = 23;
            this.lbl_to.Text = "Bis:";
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(331, 131);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 24;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(331, 158);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 25;
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
        private System.Windows.Forms.ListView listview_event;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.RichTextBox richtextbox_reason;
        private System.Windows.Forms.Label label_absencetype;
        private System.Windows.Forms.ColumnHeader Nr;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.ColumnHeader Nachname;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Bis;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button absenceTypebtn;
        private System.Windows.Forms.ComboBox cbx_absencetype;
        private System.Windows.Forms.ComboBox cbx_employee;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
    }
}

