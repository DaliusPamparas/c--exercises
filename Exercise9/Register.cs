using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Register
    {
        private string _firstName;
        private string _lastName;
        private string _ssn;
        private string _wage;
        public string _message;
        Logger newlog = new Logger();

        //Skapar list
        private List<Employee> registerList = new List<Employee>();

        //Method Skapa ny instance av employee och addera till list
        public void AddEmploeeToList()
        {
            

            //input new person data 

            Console.WriteLine("Write your first name:  ");
            _firstName = Console.ReadLine();
            Console.WriteLine("Write your last name:   ");
            _lastName = Console.ReadLine();
            Console.WriteLine("Write your Person nr.:  ");
            _ssn = Console.ReadLine();
            Console.WriteLine("Write your wage");
            _wage = Console.ReadLine();

            //ny instance av emploee 

            var person = new Employee(_firstName, _lastName, _ssn, _wage);

            //addera instance av emploee to list
            registerList.Add(person);
            _message = "We add new person to register:" + person;
            newlog.Log(_message);
       



        }

            //-----------------------------------------------------
            //method for remove person from list
           public void RemovePerson()
           {
            var _finnsNr = false;
            //input person nr. which want to remove
            Console.WriteLine("Write person nr.(10 digits)");
            var _nrToRemove = Console.ReadLine();

            //via loop find nummer in list and remove
            for (int i = 0; i < registerList.Count; i++)
            {
                
                if (registerList[i].Ssn == _nrToRemove)
                {
                    
                    _message = "We removed : " + registerList[i].FullName;
                    registerList.Remove(registerList[i]);
                    Console.WriteLine(_message);
                   
                    newlog.Log(_message);
                  
                    _finnsNr = true;
                   
                }
            }
            //check was this person inom list
            if (_finnsNr == false)
            {
                Console.WriteLine("Fel: There is no Person with nr " + _nrToRemove);
            }
           }
        //------------------------------------------------------
        //method for print register
        public void SkrivUtRegister()
        {

            foreach (var j in registerList)
            {
                j.SkrivUtEmploee();
            }
        }

    }
}




