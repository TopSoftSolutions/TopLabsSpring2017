using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var customer = new Customer();
            var creditContract = new CreditContract()
            {
                Amount = 120000,
                DurationInMonths = 24
            };

            var credit = bank.GiveCredit(customer, creditContract);

            if(credit == null)
            {
                Console.WriteLine("Qez merjel en.");
            } else
            {

            }
        }
    }
}
