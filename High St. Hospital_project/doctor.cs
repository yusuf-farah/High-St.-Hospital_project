using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class doctor
    {
        protected string doctorname;
        protected string specialtyarea;
        protected int doctoremployeeid;
        
        public string Doctorname
        {
            get { return this. doctorname; }
            set { this.doctorname = value; }
        }   

        public string Specialtyarea
        {
            get { return this. specialtyarea; }
            set { this.specialtyarea = value; }
        }
        public int Doctoremployeeid
        {
            get { return this. doctoremployeeid; }
            set { this.doctoremployeeid = value; }
        }

        public doctor(string doctorname, string  specialtyarea, int doctoremployeeid )
        {
            this.doctorname = doctorname;
            this.specialtyarea = specialtyarea;
            this.doctoremployeeid = Doctoremployeeid;
        }

           

    }
}
