using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM_4
{
    class Acount
    {
        private int balance = 0;

        
        public void Withdraw(int amount)
        {
            balance = balance - amount;
        }
       public void Deposit(int amount)
        {
            balance += amount;

        }
       public int GetBalance()
        {
            return (balance);

        }
    }
}
