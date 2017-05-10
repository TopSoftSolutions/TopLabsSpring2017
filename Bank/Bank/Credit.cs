using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Credit
    {
        private Bank _bank;
        private Customer _customer;
        public Credit(Bank bank, Customer customer)
        {
            _bank = bank;
            _customer = customer;
        }
        public int TotalAmount { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int PeriodInMonths { get; set; }
        public int DurationInMonths { get; set; }

        public decimal CustomerAccount { get; set; }

        public void GiveAmount(decimal amount)
        {
            this.CustomerAccount += amount;
        }

        public decimal CalculatePayAmount()
        {
            var days = Convert.ToInt32((DateTimeOffset.Now - this.StartDate).TotalDays);
            var leftAmount = this.TotalAmount - this.CustomerAccount;
            var amountToPay = leftAmount + days * leftAmount * _bank.Percentage / 100;
            return amountToPay;
        }
    }
}
