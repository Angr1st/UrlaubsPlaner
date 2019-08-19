using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.DBInteraction;
using UrlaubsPlaner.Entities;
using UrlaubsPlanerForms;

namespace UrlaubsPlaner.Controller
{
    public class Main_FormController
    {
        private bool IsInsert = true;
        private List<Absence> Absences;
        private List<AbsenceType> AbsenceTypes;
        private List<Employee> Employees;
        private readonly Main_Form Main_Form;
        private readonly Employee_FormController Employee_FormController;
        private readonly AbsenceType_FormController AbsenceType_FormController;

        public Main_FormController()
        {
            Main_Form = new Main_Form();

            Main_Form.Load += new System.EventHandler(this.Form_MainLoad);
            Main_Form.listview_event.SelectedIndexChanged += new System.EventHandler(this.Listview_event_SelectedIndexChanged);
            Main_Form.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            Main_Form.cbx_employee.SelectedValueChanged += new System.EventHandler(this.Cbx_employee_SelectedValueChanged);
            Main_Form.employeebtn.Click += new System.EventHandler(this.Employeebtn_Click);
            Main_Form.absenceTypebtn.Click += new System.EventHandler(this.AbsenceTypebtn_Click);
            Main_Form.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            Main_Form.button_save.Click += new System.EventHandler(this.Button_save_Click);

            var employee_Form = new Employee_Form();
            employee_Form.VisibleChanged += ShowFormAgain;
            employee_Form.FormClosed += StopProgramm;

            var absenceType_Form = new AbsenceType_Form();
            absenceType_Form.VisibleChanged += ShowFormAgain;
            absenceType_Form.FormClosed += StopProgramm;

            Employee_FormController = new Employee_FormController(employee_Form);
            AbsenceType_FormController = new AbsenceType_FormController(absenceType_Form);

            Application.Run(Main_Form);
        }

        private void Form_MainLoad(object sender, EventArgs e)
        {
            UpdateAllData();
        }

        private void UpdateAllData()
        {
            Main_Form.listview_event.Items.Clear();
            Main_Form.cbx_absencetype.Items.Clear();
            Main_Form.cbx_employee.Items.Clear();

            Absences = DataBaseConnection.GetFullAbsences();
            AbsenceTypes = DataBaseConnection.GetAbsenceTypes();
            Employees = DataBaseConnection.GetEmployees();

            Main_Form.listview_event.Items.AddRange(Absences.Select(x
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

            Main_Form.cbx_absencetype.Items.AddRange(AbsenceTypes.ToArray());

            Main_Form.cbx_employee.Items.AddRange(Employees.ToArray());
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            Employee_FormController.ShowForm();
        }

        private void AbsenceTypebtn_Click(object sender, EventArgs e)
        {
            AbsenceType_FormController.ShowForm();
        }

        private void ShowFormAgain(object sender, EventArgs e)
        {
            if (Main_Form.Visible)
            {
                Main_Form.Hide();
            }
            else
            {
                UpdateAllData();
                Main_Form.Show();
            }
        }

        private void StopProgramm(object sender, EventArgs e)
        {
            Main_Form.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Main_Form.Close();
        }

        private void Cbx_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Main_Form.cbx_employee.SelectedItem == null)
            {
                Main_Form.textbox_firstname.Text = string.Empty;
                Main_Form.textbox_lastname.Text = string.Empty;
            }
            else
            {
                var employee = CbxAsEmployee(Main_Form.cbx_employee);
                Main_Form.textbox_firstname.Text = employee.Firstname;
                Main_Form.textbox_lastname.Text = employee.Lastname;
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
            if (Main_Form.listview_event.SelectedIndices.Count == 1)
            {
                var index = Main_Form.listview_event.SelectedIndices[0];
                var selectedItem = Absences[index];
                Main_Form.txtbx_id.Text = selectedItem.AbsenceID.ToString();
                Main_Form.cbx_employee.SelectedItem = Employees.Find(x => x.EmployeeId == selectedItem.Employee.EmployeeId);
                Main_Form.cbx_absencetype.SelectedItem = AbsenceTypes.Find(x => x.AbsenceTypeId == selectedItem.AbsenceType.AbsenceTypeId);
                Main_Form.dtp_from.Value = selectedItem.FromDate;
                Main_Form.dtp_to.Value = selectedItem.ToDate;
                Main_Form.richtextbox_reason.Text = selectedItem.Reason;

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
            Main_Form.txtbx_id.Visible = visible;
            Main_Form.lbl_id.Visible = visible;
            Main_Form.btn_clear.Visible = visible;
        }

        private void ClearTextBoxes()
        {
            Main_Form.txtbx_id.Text = string.Empty;
            Main_Form.cbx_employee.SelectedItem = null;
            Main_Form.cbx_employee.Text = string.Empty;

            Main_Form.textbox_firstname.Text = string.Empty;
            Main_Form.textbox_lastname.Text = string.Empty;

            Main_Form.cbx_absencetype.SelectedItem = null;
            Main_Form.cbx_absencetype.Text = string.Empty;
            Main_Form.richtextbox_reason.Text = string.Empty;
            Main_Form.dtp_from.Value = (DateTime.Now);
            Main_Form.dtp_to.Value = (DateTime.Now);
            Main_Form.listview_event.SelectedItems.Clear();
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
                    AbsenceType = Main_Form.cbx_absencetype.SelectedItem as AbsenceType,
                    Employee = Main_Form.cbx_employee.SelectedItem as Employee,
                    FromDate = Main_Form.dtp_from.Value,
                    ToDate = Main_Form.dtp_to.Value,
                    Reason = Main_Form.richtextbox_reason.Text
                };
            }
            else
            {
                Absence selected = Absences.Find(x => x.AbsenceID.ToString() == Main_Form.txtbx_id.Text);
                selected.AbsenceType = Main_Form.cbx_absencetype.SelectedItem as AbsenceType;
                selected.Employee = Main_Form.cbx_employee.SelectedItem as Employee;
                selected.FromDate = Main_Form.dtp_from.Value;
                selected.ToDate = Main_Form.dtp_to.Value;
                selected.Reason = Main_Form.richtextbox_reason.Text;
                return selected;
            }
        }
    }
}
