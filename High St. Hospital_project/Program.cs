using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St.Hospital_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hospital_employee> employees = new List<Hospital_employee>();
            employees.Add(new doctor("james", "Oncology", 254));
            employees.Add(new nurse("emergency department ", 5, "hodan", 652));
            employees.Add(new receptionist("Jesica", 3213, "ICU", true));

            Console.WriteLine("Please enter your employeename");
            string employeename = Console.ReadLine().Trim();
            foreach (Hospital_employee e in employees)
            {
                if (e.Name.Equals(employeename))
                {
                    Console.WriteLine(e.tostring());
                }

            }
        }
    }
}
