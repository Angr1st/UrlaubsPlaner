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
    public class Employee_FormController : UrlaubsPlaner_FormControllerBase, IForm
    {
        private List<Country> Countries;
        private List<Employee> Employees;
        private readonly Employee_Form Employee_Form;

        public Employee_FormController(Employee_Form employee_Form)
        {
            Employee_Form = employee_Form;
            Employee_Form.Load += new System.EventHandler(this.Employee_Form_Load);
            Employee_Form.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            Employee_Form.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            Employee_Form.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            Employee_Form.employeeListView.SelectedIndexChanged += new System.EventHandler(this.EmployeeListView_SelectedIndexChanged);
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            Countries = DataBaseConnection.GetCountries();
            Employee_Form.cbx_country.Items.AddRange(Countries.ToArray());

            UpdateEmployeeListView();
        }

        private void UpdateEmployeeListView()
        {
            Employee_Form.employeeListView.Items.Clear();
            Employees = DataBaseConnection.GetFullEmployees();
            Employee_Form.employeeListView.Items.AddRange(Employees.Select(x
                => new ListViewItem(new string[]
                {
                    x.EmployeeId.ToString(),
                    x.EmployeeNumber.ToString(),
                    x.Country.Code,
                    x.Firstname,
                    x.Lastname,
                    x.Email
                })).ToArray());
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Employee_Form.Hide();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            DataBaseConnection.UpsertEmployee(GetCurrentEmployee(), IsInsert);
            UpdateEmployeeListView();
        }

        private Employee GetCurrentEmployee()
        {
            if (IsInsert)
            {
                return new Employee()
                {
                    Birthday = Employee_Form.dtm_birthday.Value,
                    City = Employee_Form.txtbx_city.Text,
                    Country = Employee_Form.cbx_country.SelectedItem as Country,
                    Email = Employee_Form.txtbx_email.Text,
                    EmployeeId = Guid.NewGuid(),
                    EmployeeNumber = Employees.Max(x => x.EmployeeNumber) + 1,
                    Firstname = Employee_Form.txtbx_firstname.Text,
                    Housenumber = Employee_Form.txtbx_housenumber.Text,
                    Lastname = Employee_Form.txtbx_lastname.Text,
                    Phonenumber = Employee_Form.txtbx_telefonnumber.Text,
                    Postalcode = Employee_Form.txtbx_postalcode.Text,
                    Street = Employee_Form.txtbx_street.Text
                };
            }
            else
            {
                Employee selected = Employees.Find(x => x.EmployeeId.ToString() == Employee_Form.txtbx_id.Text);
                selected.Birthday = Employee_Form.dtm_birthday.Value;
                selected.City = Employee_Form.txtbx_city.Text;
                selected.Country = Employee_Form.cbx_country.SelectedItem as Country;
                selected.Email = Employee_Form.txtbx_email.Text;
                selected.Firstname = Employee_Form.txtbx_firstname.Text;
                selected.Housenumber = Employee_Form.txtbx_housenumber.Text;
                selected.Lastname = Employee_Form.txtbx_lastname.Text;
                selected.Phonenumber = Employee_Form.txtbx_telefonnumber.Text;
                selected.Postalcode = Employee_Form.txtbx_postalcode.Text;
                selected.Street = Employee_Form.txtbx_street.Text;
                return selected;
            }
        }

        private void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Employee_Form.employeeListView.SelectedIndices.Count == 1)
            {
                var index = Employee_Form.employeeListView.SelectedIndices[0];
                var selectedItem = Employees[index];
                Employee_Form.txtbx_firstname.Text = selectedItem.Firstname;
                Employee_Form.txtbx_city.Text = selectedItem.City;
                Employee_Form.txtbx_email.Text = selectedItem.Email;
                Employee_Form.txtbx_housenumber.Text = selectedItem.Housenumber;
                Employee_Form.txtbx_id.Text = selectedItem.EmployeeId.ToString();
                Employee_Form.txtbx_lastname.Text = selectedItem.Lastname;
                Employee_Form.txtbx_number.Text = selectedItem.EmployeeNumber.ToString();
                Employee_Form.txtbx_postalcode.Text = selectedItem.Postalcode;
                Employee_Form.txtbx_street.Text = selectedItem.Street;
                Employee_Form.txtbx_telefonnumber.Text = selectedItem.Phonenumber;
                Employee_Form.dtm_birthday.Value = selectedItem.Birthday.GetValueOrDefault();
                Employee_Form.cbx_country.SelectedItem = Countries.Find(x => x.CountryId == selectedItem.Country.CountryId);

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
            Employee_Form.txtbx_id.Visible = visible;
            Employee_Form.lbl_ID.Visible = visible;
            Employee_Form.btn_clear.Visible = visible;
            Employee_Form.txtbx_number.Visible = visible;
            Employee_Form.lbl_number.Visible = visible;
        }

        private void ClearTextBoxes()
        {
            Employee_Form.txtbx_id.Text = string.Empty;
            Employee_Form.txtbx_city.Text = string.Empty;
            Employee_Form.txtbx_email.Text = string.Empty;
            Employee_Form.txtbx_firstname.Text = string.Empty;
            Employee_Form.txtbx_lastname.Text = string.Empty;
            Employee_Form.txtbx_number.Text = string.Empty;
            Employee_Form.txtbx_postalcode.Text = string.Empty;
            Employee_Form.txtbx_street.Text = string.Empty;
            Employee_Form.txtbx_housenumber.Text = string.Empty;
            Employee_Form.txtbx_telefonnumber.Text = string.Empty;
            Employee_Form.dtm_birthday.Value = DateTime.Now;
            Employee_Form.cbx_country.SelectedItem = null;
        }

        private void ChangeButtonText(bool isInsert)
        {
            if (isInsert)
            {
                Employee_Form.btn_create.Text = "Erstellen";
            }
            else
            {
                Employee_Form.btn_create.Text = "Aktualisieren";
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ToggleInsertOrUpdate(false);
        }

        public void ShowForm()
        {
            Employee_Form.Show();
        }
    }
}
