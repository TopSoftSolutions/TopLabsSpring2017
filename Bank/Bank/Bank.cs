using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Percentage { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }
        public Currency Currency { get; set; }
        public List<Credit> Credits = new List<Credit>();
        public List<Customer> Customers = new List<Customer>();

        public Credit GiveCredit(Customer customer, CreditContract creditContract)
        {
            if (customer.Approved == false) { return null; }
            if (creditContract.Amount > this.MaxAmount || creditContract.Amount < this.MinAmount) { return null; }
            Credit credit = new Credit(this, customer)
            {
                StartDate = DateTimeOffset.Now,
                DurationInMonths = creditContract.DurationInMonths,
                TotalAmount = creditContract.Amount,
                PeriodInMonths = 1,
            };
            customer.Credits.Add(credit);
            this.Credits.Add(credit);
            this.Customers.Add(customer);

            return credit;

        }
    }
}
