using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public string Ssn { get; private set; }
        private string Wage { get; set; }
        public Employee(string firstName, string lastName, string ssn, string wage)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Wage = wage;

        }
        public Employee(string ssn)
        {

            Ssn = ssn;

        }

        public void AddEmploee()
        {
            Console.WriteLine("Skriv din Namn");


        }

        public void SkrivUtEmploee()
        {
            Console.WriteLine("Namn Efternamn: " + FirstName +" "+ LastName);
            Console.WriteLine("Persson nr.: " + Ssn);
            Console.WriteLine("Wage: " + Wage);

        }
        public void SkrivUtSsn()
        {
            Console.WriteLine("Person nr:   " + Ssn);
        }
        public string FullName { get { return LastName + " " + FirstName; } }

    }
}
