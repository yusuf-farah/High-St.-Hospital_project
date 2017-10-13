using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    public class surgeon : doctor
    {

        protected bool operating;


        public bool Operating
        {
            get { return this.operating; }
            set { this.operating = value; }
        }

        public surgeon(string name, int employeenumber, string specialtyarea, bool operating) : base(name, specialtyarea, employeenumber)
        {
            this.operating = operating;

        }
        public override string ToString()
        {
            string isoperating = operating  == true ? " isoperating " : "  not operating";
            return this.name + " " + this.employeenumber + " " + specialtyarea + "  " + isoperating;

        }
    }

}
    

