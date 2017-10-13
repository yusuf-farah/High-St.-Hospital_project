using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class nurse:Hospital_employee
    {
        protected string department;
        protected int numberOfPatients;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

            public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }

        }
        public nurse(string department, int numberOfPatients, string name, int employeenumber)
        {
            this.department = department;
            this.numberOfPatients = numberOfPatients;
            this.name = name;
            this.employeenumber = employeenumber;
        }

        public override string ToString()
        {
           
         return this.name + " " + this.employeenumber + " " + this.department + " " + this.numberOfPatients;
        }

    }
}
