using System;
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
        private bool IsInsert = true;
        private List<AbsenceType> AbsenceTypes;


        public AbsenceType_Form()
        {
            InitializeComponent();
            this.Hide();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataBaseConnection.UpsertAbsenceType(new AbsenceType() { AbsenceTypeId = txbx_id.Text != string.Empty ? new Guid(txbx_id.Text) : Guid.NewGuid(), Label = absenceType_Label.Text }, IsInsert);
            UpdataAbsenceTypes();
        }

        private void AbsenceType_Form_Load(object sender, EventArgs e)
        {
            UpdataAbsenceTypes();
        }

        private void UpdataAbsenceTypes()
        {
            absenceTypeListView.Items.Clear();
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

        private void AbsenceTypeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (absenceTypeListView.SelectedIndices.Count == 1)
            {
                var index = absenceTypeListView.SelectedIndices[0];
                var listViewItem = absenceTypeListView.Items[index];
                absenceType_Label.Text = listViewItem.SubItems[1].Text;
                txbx_id.Text = listViewItem.SubItems[0].Text;
                ToggleInsertOrUpdate(true);
            }
        }

        private void ToggleInsertOrUpdate(bool visible)
        {
            IsInsert = !visible;
            ToggleButtonVisibility(visible);
            ChangeButtonText(!visible);

            if (!visible)
                ClearTextBoxes();
        }

        private void ToggleButtonVisibility(bool visible)
        {
            txbx_id.Visible = visible;
            lb_Id.Visible = visible;
            btn_clear.Visible = visible;
        }

        private void ClearTextBoxes()
        {
            txbx_id.Text = string.Empty;
            absenceType_Label.Text = string.Empty;
        }

        private void ChangeButtonText(bool isInsert)
        {
            if (isInsert)
            {
                createButton.Text = "Erstellen";
            }
            else
            {
                createButton.Text = "Aktualisieren";
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ToggleInsertOrUpdate(false);
        }
    }
}
