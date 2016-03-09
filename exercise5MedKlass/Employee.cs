using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5MedKlass
{
    class Employee
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _ssn { get; set; }
        private string _wage { get; set; }
        public Employee(string firstName, string lastName, string ssn, string wage)
        {
            _firstName = firstName;
            _lastName = lastName;
            _ssn = ssn;
            _wage = wage;

        }
        public Employee(string ssn)
        {

            _ssn = ssn;

        }

        public void SkrivUtEmploee()
        {
            Console.WriteLine("Namn Efternamn: " + _firstName + _lastName);
            Console.WriteLine("Persson nr.: " + _ssn);
            Console.WriteLine("Wage: " + _wage);

        }
        public void SkrivUtSsn()
        {
            Console.WriteLine("Person nr:   " + _ssn);
        }
        public string FullName { get { return _lastName + _firstName; } }

    }
}
