﻿namespace UrlaubsPlaner
{
    partial class AbsenceType_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenceType_Form));
            this.absenceTypeListView = new System.Windows.Forms.ListView();
            this.absenceTypeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.absenceTypeLabel = new System.Windows.Forms.Label();
            this.absenceType_Label = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // absenceTypeListView
            // 
            this.absenceTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.absenceTypeID,
            this.label});
            this.absenceTypeListView.FullRowSelect = true;
            this.absenceTypeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.absenceTypeListView.Location = new System.Drawing.Point(13, 13);
            this.absenceTypeListView.MultiSelect = false;
            this.absenceTypeListView.Name = "absenceTypeListView";
            this.absenceTypeListView.Size = new System.Drawing.Size(358, 425);
            this.absenceTypeListView.TabIndex = 0;
            this.absenceTypeListView.UseCompatibleStateImageBehavior = false;
            this.absenceTypeListView.View = System.Windows.Forms.View.Details;
            this.absenceTypeListView.SelectedIndexChanged += new System.EventHandler(this.AbsenceTypeListView_SelectedIndexChanged);
            // 
            // absenceTypeID
            // 
            this.absenceTypeID.Text = "ID";
            this.absenceTypeID.Width = 149;
            // 
            // label
            // 
            this.label.Text = "Label";
            this.label.Width = 205;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.absenceTypeLabel);
            this.groupBox1.Controls.Add(this.absenceType_Label);
            this.groupBox1.Location = new System.Drawing.Point(397, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new AbsenceType";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(161, 120);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Erstellen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // absenceTypeLabel
            // 
            this.absenceTypeLabel.AutoSize = true;
            this.absenceTypeLabel.Location = new System.Drawing.Point(70, 47);
            this.absenceTypeLabel.Name = "absenceTypeLabel";
            this.absenceTypeLabel.Size = new System.Drawing.Size(33, 13);
            this.absenceTypeLabel.TabIndex = 1;
            this.absenceTypeLabel.Text = "Label";
            // 
            // absenceType_Label
            // 
            this.absenceType_Label.Location = new System.Drawing.Point(70, 66);
            this.absenceType_Label.Name = "absenceType_Label";
            this.absenceType_Label.Size = new System.Drawing.Size(274, 20);
            this.absenceType_Label.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(665, 414);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Abbrechen";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AbsenceType_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.absenceTypeListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbsenceType_Form";
            this.Text = "AbsenceType_Form";
            this.Load += new System.EventHandler(this.AbsenceType_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView absenceTypeListView;
        private System.Windows.Forms.ColumnHeader absenceTypeID;
        private System.Windows.Forms.ColumnHeader label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label absenceTypeLabel;
        private System.Windows.Forms.TextBox absenceType_Label;
        private System.Windows.Forms.Button cancelBtn;
    }
}