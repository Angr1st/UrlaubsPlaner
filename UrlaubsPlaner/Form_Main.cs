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
    public partial class Form_Main : Form
    {
        private bool IsInsert = true;
        private List<Absence> Absences;
        private List<AbsenceType> AbsenceTypes;
        private List<Employee> Employees;
        private readonly Employee_Form Employee_Form;
        private readonly AbsenceType_Form AbsenceType_Form;


        public Form_Main()
        {
            InitializeComponent();

            Employee_Form = new Employee_Form();
            Employee_Form.VisibleChanged += ShowFormAgain;
            Employee_Form.FormClosed += StopProgramm;

            AbsenceType_Form = new AbsenceType_Form();
            AbsenceType_Form.VisibleChanged += ShowFormAgain;
            AbsenceType_Form.FormClosed += StopProgramm;
        }

        private void Form_MainLoad(object sender, EventArgs e)
        {
            UpdateAllData();
        }

        private void UpdateAllData()
        {
            listview_event.Items.Clear();
            cbx_absencetype.Items.Clear();
            cbx_employee.Items.Clear();

            Absences = DataBaseConnection.GetFullAbsences();
            AbsenceTypes = DataBaseConnection.GetAbsenceTypes();
            Employees = DataBaseConnection.GetEmployees();

            listview_event.Items.AddRange(Absences.Select(x
                => new ListViewItem(new string[]
                {
                    x.AbsenceID.ToString(),
                    x.Employee.EmployeeNumber.ToString(),
                    x.Employee.Firstname,
                    x.Employee.Lastname,
                    x.AbsenceType.Label,
                    x.FromDate.ToString(),
                    x.ToDate.ToString()
                })).ToArray());

            cbx_absencetype.Items.AddRange(AbsenceTypes.ToArray());

            cbx_employee.Items.AddRange(Employees.ToArray());
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            Employee_Form.Show();
        }

        private void AbsenceTypebtn_Click(object sender, EventArgs e)
        {
            AbsenceType_Form.Show();
        }

        private void ShowFormAgain(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                UpdateAllData();
                this.Show();
            }
        }

        private void StopProgramm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbx_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbx_employee.SelectedItem == null)
            {
                textbox_firstname.Text = string.Empty;
                textbox_lastname.Text = string.Empty;
            }
            else
            {
            var employee = CbxAsEmployee(cbx_employee);
            textbox_firstname.Text = employee.Firstname;
            textbox_lastname.Text = employee.Lastname;
            }

            Employee CbxAsEmployee(ComboBox box)
            {
                if (box.SelectedItem is Employee)
                {
                    return box.SelectedItem as Employee;
                }
                throw new InvalidOperationException("This combobox should contain employee objects!");
            }
        }

        private void Listview_event_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listview_event.SelectedIndices.Count == 1)
            {
                var index = listview_event.SelectedIndices[0];
                var selectedItem = Absences[index];
                txtbx_id.Text = selectedItem.AbsenceID.ToString();
                cbx_employee.SelectedItem = Employees.Find(x => x.EmployeeId == selectedItem.Employee.EmployeeId);
                cbx_absencetype.SelectedItem = AbsenceTypes.Find(x => x.AbsenceTypeId == selectedItem.AbsenceType.AbsenceTypeId);
                dtp_from.Value = selectedItem.FromDate;
                dtp_to.Value = selectedItem.ToDate;
                richtextbox_reason.Text = selectedItem.Reason;

                ToggleInsertOrUpdate(true);
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ToggleInsertOrUpdate(false);
        }

        private void ToggleInsertOrUpdate(bool visible)
        {
            IsInsert = !visible;
            ToggleButtonVisibility(visible);

            if (!visible)
                ClearTextBoxes();
        }

        private void ToggleButtonVisibility(bool visible)
        {
            txtbx_id.Visible = visible;
            lbl_id.Visible = visible;
            btn_clear.Visible = visible;
        }

        private void ClearTextBoxes()
        {
            txtbx_id.Text = string.Empty;
            cbx_employee.SelectedItem = null;
            cbx_employee.Text = string.Empty;

            textbox_firstname.Text = string.Empty;
            textbox_lastname.Text = string.Empty;

            cbx_absencetype.SelectedItem = null;
            cbx_absencetype.Text = string.Empty;
            richtextbox_reason.Text = string.Empty;
            dtp_from.Value = (DateTime.Now);
            dtp_to.Value = (DateTime.Now);
            listview_event.SelectedItems.Clear();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            DataBaseConnection.UpsertAbsence(GetCurrentAbsence(), IsInsert);
            UpdateAllData();
        }

        private Absence GetCurrentAbsence()
        {
            if (IsInsert)
            {
                return new Absence()
                {
                    AbsenceID = Guid.NewGuid(),
                    AbsenceType = cbx_absencetype.SelectedItem as AbsenceType,
                    Employee = cbx_employee.SelectedItem as Employee,
                    FromDate = dtp_from.Value,
                    ToDate = dtp_to.Value,
                    Reason = richtextbox_reason.Text
                };
            }
            else
            {
                Absence selected = Absences.Find(x => x.AbsenceID.ToString() == txtbx_id.Text);
                selected.AbsenceType = cbx_absencetype.SelectedItem as AbsenceType;
                selected.Employee = cbx_employee.SelectedItem as Employee;
                selected.FromDate = dtp_from.Value;
                selected.ToDate = dtp_to.Value;
                selected.Reason = richtextbox_reason.Text;
                return selected;
            }
        }
    }
}