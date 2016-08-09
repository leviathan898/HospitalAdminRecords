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
    public partial class StaffRecords : Form
    {
        //instantiate the class containing the staff list, binding source for show all and binding source for search
        PeopleList staffList = new PeopleList();
        BindingSource bs = new BindingSource();
        BindingSource bsSearch = new BindingSource();
        
        public StaffRecords()
        {
            InitializeComponent();
            //center current scope component
            this.CenterToScreen();

            //use enum to populate combobox for title
            cmbStaffTitle.DataSource = Enum.GetValues(typeof(EnumTitles));
            //prevent editing of stored values through the data grid
            dgvStaff.ReadOnly = true;
            dgvStaff.AllowUserToAddRows = false;

        }

        private void btnStaffBack_Click(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string title, fname, lname, dob, email, phone, id;

            //use inputs to initalise variables
            title = cmbStaffTitle.Text;
            fname = txtStaffFName.Text;
            lname = txtStaffLName.Text;
            dob = dtpStaffDOB.Value.ToShortDateString();
            email = txtStaffEmail.Text;
            phone = txtStaffPhone.Text;
            id = txtStaffID.Text;

            //call add staff method to use variables to populate staff properties and create new instance of staff
            lblDisplayStaff.Text = staffList.AddStaff(title, fname, lname, dob, phone, email, id);

            //if instance of class was successful, clear the form
            if (lblDisplayStaff.Text.Equals("Data added."))
            {
                txtStaffFName.Clear();
                txtStaffLName.Clear();
                txtStaffEmail.Clear();
                txtStaffPhone.Clear();
                txtStaffID.Clear();
            }

            //focus to ID field if add not successful
            else
            {
                txtStaffID.Focus();
            }
        }

        private void lblDisplayStaff_Click(object sender, EventArgs e)
        {
            //empty
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            //clear the list box
            lstStaff.Items.Clear();

            //clear display messages
            lblDisplayStaff.Text = "";

            //cycle through staff in stafflist and use ToString method to add each property as a string to list items
            foreach (Staff staffInList in staffList.StaffMembers)
            {
                lstStaff.Items.Add(staffInList.ToString());
            }

            ConvertListToDataTable(staffList.StaffMembers);
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            //clear the list
            lstStaff.Items.Clear();

            string id, message;
            bool failed;

            //create new instance of staff to initialise later
            Staff matchedStaff = new Staff();

            //id = input
            id = txtStaffID.Text;

            //call search staff method, pass id and output matchedstaff and message
            staffList.SearchStaff(id, out matchedStaff, out message, out failed);

            //if search failed, focus on ID text box
            if (failed == false)
            {
                txtStaffID.Focus();
            }

            //use ToString method to add matchedstaff properties as a string to list box items
            lstStaff.Items.Add(matchedStaff.ToString());

            //if search gives no results, write null for every null property
            this.dgvStaff.DefaultCellStyle.NullValue = "Null";

            //populate binding list 'Search' with matched staff entry
            bsSearch.DataSource = matchedStaff;
            //use binding list 'Search' as data source for data grid
            dgvStaff.DataSource = bsSearch;

            //call reset bindings to update the binding list
            bsSearch.ResetBindings(false);

            //clear input boxes
            txtStaffFName.Clear();
            txtStaffLName.Clear();
            txtStaffEmail.Clear();
            txtStaffPhone.Clear();
            txtStaffID.Clear();

            //display message passed out from search method
            lblDisplayStaff.Text = message;
        }

        private void btnStaffContactDetails_Click(object sender, EventArgs e)
        {
            //clear message display
            lblDisplayStaff.Text = "";

            //clear list box
            lstStaff.Items.Clear();

            //cycle through staff and add string of ID, email, phone into list box
            foreach (Staff staffInList in staffList.StaffMembers)
            {
                lstStaff.Items.Add(string.Format(staffInList.ID + " " + staffInList.Email + " " + staffInList.Phone));
            }

            ConvertListToDataTable(staffList.StaffMembers);
        }

        private void btnStaffNames_Click(object sender, EventArgs e)
        {
            //clear message display
            lblDisplayStaff.Text = "";

            //clear list box
            lstStaff.Items.Clear();

            //cycle through staff and add string of ID, first name and last name
            foreach (Staff staffInList in staffList.StaffMembers)
            {
                lstStaff.Items.Add(string.Format(staffInList.ID + " " + staffInList.FName + " " + staffInList.LName));
            }

            ConvertListToDataTable(staffList.StaffMembers);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            //clear message display
            lstStaff.Items.Clear();

            //create new staff object to use for selected staff to delete
            Staff selectedStaff = new Staff();

            //if no rows are selected and delete button clicked, display this message
            if (dgvStaff.RowCount == 0)
            {
                lblDisplayStaff.Text = "Please select a staff record to delete.";
            }

            //if rows are selected, instantiate creates staff object with selection and cast the item bound to the data grid as type Staff
            //display message box asking user to confirm
            //if confrimed, call delete method and pass on selected staff object, returned string is used for display message
            else
            {
                selectedStaff = (Staff)dgvStaff.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show("Delete this record?" + selectedStaff.ToString(), "delete", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    lblDisplayStaff.Text = staffList.DeleteStaff(selectedStaff);
                }
                
            }

            ConvertListToDataTable(staffList.StaffMembers);
        }

        private void txtStaffLName_TextChanged(object sender, EventArgs e)
        {
            //empty
        }

        //create method to pass values to binding source, populate datagrid
        void ConvertListToDataTable(List<Staff> StaffMembers)
        {
            BindingSource bs = new BindingSource();

            //populate binding list data with staff
            bs.DataSource = staffList.StaffMembers;

            //use binding list as data grid data source
            dgvStaff.DataSource = bs;

            //call reset bindings to update the binding list
            bs.ResetBindings(false);
        }
    }
}
