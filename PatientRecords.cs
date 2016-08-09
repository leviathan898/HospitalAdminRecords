using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andyCheung_B8IT117
{
    public partial class PatientRecords : Form
    {
        //instantiate class containing the patient list, binding source for show all and binding source for search
        PeopleList patientList = new PeopleList();
        BindingSource bsSearch = new BindingSource();

        public PatientRecords()
        {
            InitializeComponent();
            //center current scope component
            this.CenterToScreen();

            //use enum to populate combobox for title
            cmbPatientTitle.DataSource = Enum.GetValues(typeof(EnumTitles));
            //prevent editing of stored values through the data grid
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;
        }

        private void btnPatientBack_Click(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empty
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string title, fname, lname, dob, email, phone, id;

            //use inputs to initalise variables
            title = cmbPatientTitle.Text;
            fname = txtPatientFName.Text;
            lname = txtPatientLName.Text;
            dob = dtpPatientDOB.Value.ToShortDateString();
            email = txtPatientEmail.Text;
            phone = txtPatientPhone.Text;
            id = txtPatientID.Text;

            //call add patient method to use variables to populate paatient properties and create new instance of patient
            lblDisplayPatient.Text = patientList.AddPatient(title, fname, lname, dob, phone, email, id);

            //if instance of class was successful, clear the form
            if (lblDisplayPatient.Text.Equals("Data added."))
            {
                txtPatientFName.Clear();
                txtPatientLName.Clear();
                txtPatientEmail.Clear();
                txtPatientPhone.Clear();
                txtPatientID.Clear();
            }

            //focus to ID field if add not successful
            else
            {
                txtPatientID.Focus();
            }
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            //clear the list
            lstPatients.Items.Clear();

            string id, message;
            bool failed;

            //create new instance of patient to initialise later
            Patient matchedPatient = new Patient();

            //id = input
            id = txtPatientID.Text;

            //call search patient method, pass id and output matchedpatient and message
            patientList.SearchPatients(id, out matchedPatient, out message, out failed);

            //if search failed, focus on ID text box
            if (failed == false)
            {
                txtPatientID.Focus();
            }

            //use ToString method to add matchedpatient properties as a string to list box items
            lstPatients.Items.Add(matchedPatient.ToString());

            //if search gives no results, write null for every null property
            this.dgvPatients.DefaultCellStyle.NullValue = "Null";

            //populate binding list 'Search' with matched patient entry
            bsSearch.DataSource = matchedPatient;
            //use binding list 'Search' as data source for data grid
            dgvPatients.DataSource = bsSearch;

            //call reset bindings to update the binding list
            bsSearch.ResetBindings(false);

            //clear input boxes
            txtPatientFName.Clear();
            txtPatientLName.Clear();
            txtPatientEmail.Clear();
            txtPatientPhone.Clear();
            txtPatientID.Clear();

            //display message passed out from search method
            lblDisplayPatient.Text = message;
        }

        private void btnShowPatients_Click(object sender, EventArgs e)
        {
            //clear display messages
            lblDisplayPatient.Text = "";

            //clear the list box
            lstPatients.Items.Clear();

            //cycle through patients in patientlist and use ToString method to add each property as a string to list items
            foreach (Patient patientsInList in patientList.Patients)
            {
                lstPatients.Items.Add(patientsInList.ToString());
            }

            ConvertListToDataTable(patientList.Patients);
        }

        private void btnPatientContactDetails_Click(object sender, EventArgs e)
        {
            //clear message display
            lblDisplayPatient.Text = "";

            //clear list box
            lstPatients.Items.Clear();

            //cycle through patient and add string of ID, email, phone into list box
            foreach (Patient patientsInList in patientList.Patients)
            {
                lstPatients.Items.Add(string.Format(patientsInList.ID + " " + patientsInList.Email + " " + patientsInList.Phone));
            }

            ConvertListToDataTable(patientList.Patients);
        }

        private void btnPatientNames_Click(object sender, EventArgs e)
        {
            //clear message display
            lblDisplayPatient.Text = "";

            //clear list box
            lstPatients.Items.Clear();

            //cycle through patient and add string of ID, first name and last name
            foreach (Patient patientsInList in patientList.Patients)
            {
                lstPatients.Items.Add(string.Format(patientsInList.ID + " " + patientsInList.FName + " " + patientsInList.LName));
            }

            ConvertListToDataTable(patientList.Patients);
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            //clear message display
            lstPatients.Items.Clear();

            //create new patient object to use for selected patient to delete
            Patient selectedPatient = new Patient();

            //if no rows are selected and delete button clicked, display this message
            if (dgvPatients.RowCount == 0)
            {
                lblDisplayPatient.Text = "Please select a patient record to delete.";
            }

            //if rows are selected, instantiate creates staff object with selection and cast the item bound to the data grid as type Patient
            //display message box asking user to confirm
            //if confirmed, call delete method and pass on selected patient object, returned string is used for display message
            else
            {
                selectedPatient = (Patient)dgvPatients.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show("Delete this record?\n" + selectedPatient.ToString(), "delete", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    lblDisplayPatient.Text = patientList.DeletePatient(selectedPatient);
                }

            }

            ConvertListToDataTable(patientList.Patients);
        }

        //create method to pass values to binding source, populate datagrid
        void ConvertListToDataTable(List<Patient> Patients)
        {
            BindingSource bs = new BindingSource();

            //populate binding list data with patient
            bs.DataSource = patientList.Patients;

            //use binding list as data grid data source
            dgvPatients.DataSource = bs;

            //call reset bindings to update the binding list
            bs.ResetBindings(false);
        }

        private void dtpPatientDOB_ValueChanged(object sender, EventArgs e)
        {
            //empty
        }
    }
}
