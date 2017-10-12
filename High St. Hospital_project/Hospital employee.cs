using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class Hospital_employee
    {   // fields 
        protected string name;
        protected int employeenumber;
        //properties
        public string Name
        {
            get { return this. name; }
            set { this.name = value; }
        }
       public int Employeenumber
        {
            get { return this.employeenumber; }
            set { this.employeenumber = value; }
        }
        public Hospital_employee() //
        {
        }
        // bellow code is method
        public Hospital_employee(string name, int employeenumber)
        {   
            this.name= name;
            this.employeenumber = employeenumber;
        
        }
        






    }
}
