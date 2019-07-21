﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.DBInteraction;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner
{
    public partial class AbsenceType_Form : Form
    {
        List<AbsenceType> AbsenceTypes;

        public AbsenceType_Form()
        {
            InitializeComponent();
            this.Hide();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void AbsenceType_Form_Load(object sender, EventArgs e)
        {
            AbsenceTypes = DataBaseConnection.GetAbsenceTypes();
            absenceTypeListView.Items.AddRange(AbsenceTypes.Select(x
                => new ListViewItem(new string[]
                {
                    x.AbsenceTypeId.ToString(),
                    x.Label
                })).ToArray());
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
