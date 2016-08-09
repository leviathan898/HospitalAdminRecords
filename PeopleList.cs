using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andyCheung_B8IT117
{
    public class PeopleList
    {
        //create and instantiate lists of type staff and patients
        internal List<Staff> StaffMembers = new List<Staff>();
        internal List<Patient> Patients = new List<Patient>();

        //create add staff method
        public string AddStaff(string title, string fname, string lname, string dob, string phone, string email, string id)
        {
            int parsedid, check = 0;
            bool parsecheck;

            //check if id can be parsed into int
            parsecheck = int.TryParse(id, out parsedid);

            //if id isn't an int or is 0
            if (parsecheck == false || parsedid < 1 || title == "" || fname == "" || lname == "" || dob == "" || phone == "" || email == "")
            {
                check = 1;
            }

            else
            {
                //if id is int, check if id exists already
                foreach (Staff member in StaffMembers)
                {
                    //compare id input with ID property
                    if (member.ID == parsedid)
                    {
                        check = 2;
                    }
                    else
                    {
                        check = 3;
                    }
                }
            }

            //display appropriate error messages, or else create a new instance of class, populate properties and add to staff list
            switch (check)
            {
                case 1:
                    {
                        return ("Error: Please fill in all fields with correct entries.");
                    }

                case 2:
                    {
                        return ("Error: ID already exists.");
                    }

                default:
                    {
                        Staff s = new Staff();

                        s.FName = fname;
                        s.LName = lname;
                        s.DOB = dob;
                        s.Phone = phone;
                        s.Email = email;
                        s.ID = parsedid;
                        s.Title = (EnumTitles)Enum.Parse(typeof(EnumTitles), title);


                        StaffMembers.Add(s);

                        return ("Data added.");
                    }
            }
        }

        //create method to add patient
        public string AddPatient(string title, string fname, string lname, string dob, string phone, string email, string id)
        {
            int parsedid, check = 0;
            bool parsecheck;
            
            //check if id can be parsed into int
            parsecheck = int.TryParse(id, out parsedid);

            //if id isn't an int or is 0
            if (parsecheck == false || parsedid < 1 || title == "" || fname == "" || lname == "" || dob == "" || phone == "" || email == "")
            {
                check = 1;
            }

            else
            {
                //if id is int, check if id exists already
                foreach (Patient patient in Patients)
                {
                    //compare id input with ID property, also check if ID is int
                    if (patient.ID == parsedid)
                    {
                        check = 2;
                    }
                    else
                    {
                        check = 3;
                    }
                }
            }

            //display appropriate error messages, or else create a new instance of class, populate properties, add to patient list and display success message
            switch (check)
            {
                case 1:
                    {
                        return ("Error: Please fill in all fields with correct entries.");
                    }

                case 2:
                    {
                        return ("Error: ID already exists.");
                    }

                default:
                    {
                        Patient p = new Patient();

                        p.FName = fname;
                        p.LName = lname;
                        p.DOB = dob;
                        p.Phone = phone;
                        p.Email = email;
                        p.ID = parsedid;
                        p.Title = (EnumTitles)Enum.Parse(typeof(EnumTitles), title);

                        Patients.Add(p);

                        return ("Data added.");
                    }
            }
        }

        //create search patient by ID method with parameter string id, with output values of Patient and string types
        public void SearchPatients(string id, out Patient matchedPatient, out string message, out bool failed)
        {
            int parsedid;
            int.TryParse(id, out parsedid);

            //default value of message
            message = "ID not found.";

            //default value of bool
            failed = false;

            //create new instance of patient for later use
            matchedPatient = new Patient();

            //cycle through patients in list Patients
            foreach (Patient patientInList in Patients)
            {
                //if ID is unique and valid, matchedPatient created earlier is given value of matched patient
                //message value changes
                if (id != null && parsedid > 0 && parsedid == patientInList.ID)
                {
                    matchedPatient = patientInList;
                    message = "ID found.";
                    failed = true;
                }
            }
        }

        //create search staff by ID method, use pass-by-value to return two values
        public void SearchStaff(string id, out Staff matchedStaff, out string message, out bool failed)
        {
            int parsedid;
            int.TryParse(id, out parsedid);

            //default message value
            message = "ID not found.";

            //default value of bool
            failed = false;

            //create new isntances of patient to be used later
            matchedStaff = new Staff();

            //cycle through staff in list StaffMembers
            foreach (Staff staffInList in StaffMembers)
            {
                //if ID is unique and valid, initialise created Staff object above with matched patient
                //change message value
                if (id != null && parsedid > 0 && parsedid == staffInList.ID)
                {
                    matchedStaff = staffInList;
                    message = "ID found.";
                    failed = true;
                }
            }
        }

        //method to delete staff
        public string DeleteStaff(Staff selectedStaff)
        {
            //remove passed Staff object argument from list
            StaffMembers.Remove(selectedStaff);

            return "Staff deleted.";
        }

        //method to delete patient
        internal string DeletePatient(Patient selectedPatient)
        {
            //remove passed Patient object argument from list
            Patients.Remove(selectedPatient);

            return "Patient deleted.";
        }
    }
}
