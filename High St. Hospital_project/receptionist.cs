using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class receptionist:Hospital_employee
    {
        // fields
       
        
        public string department;
        protected bool  phone;
       
        
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public bool Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

            public receptionist(string name, int employeenumber, string department, bool phone)
        {
                this.name = name;
                this.employeenumber = employeenumber;
                this.department = department;
                this.phone = phone; 
        }

        public override string tostring()
        { string onphone = phone == true ? " on phone" : "not on the phone";
            return this.name + " " + this.employeenumber + " " + this.department + " " + onphone;
        }

    }
}
