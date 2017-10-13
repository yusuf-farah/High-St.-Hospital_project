using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
   public class doctor:Hospital_employee
    {
       
        protected string specialtyarea;
        
        
       

        public string Specialtyarea
        {
            get { return this. specialtyarea; }
            set { this.specialtyarea = value; }
        }
      
        

     public doctor(string name, string  specialtyarea, int employeenumber )
        {
            this.name = name;
            this.specialtyarea = specialtyarea;
            this.employeenumber = employeenumber;
        }
        public override string ToString()
        {
            return this.name + " " + this.employeenumber + " " + specialtyarea;
        }
    }
}
