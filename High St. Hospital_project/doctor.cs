using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class doctor:Hospital_employee
    {
       
        protected string specialtyarea;
        
        
       

        public string Specialtyarea
        {
            get { return this. specialtyarea; }
            set { this.specialtyarea = value; }
        }
      
        

     public doctor(string doctorname, string  specialtyarea, int doctoremployeeid )
        {
            this.name = name;
            this.specialtyarea = specialtyarea;
            this.employeenumber = employeenumber;
        }

           

    }
}
