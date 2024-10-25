using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public abstract class Account
    {
        public string name;
        public string surname;
        public string accountNumber;
        public string type;
        public int surchargeDate;
        public decimal balance;

        public Account()
        {
            
        }
        public Account(string name, string surname, string accountNumber, string type, int surchargeDate, decimal balance)
        {
            this.name = name;
            this.surname = surname;
            this.accountNumber = accountNumber;
            this.type = type;
            this.surchargeDate = surchargeDate;
            this.balance = balance;
        }

        protected string Name { get => name; set => name = value; }
        protected string Surname { get => surname; set => surname = value; }
        protected string AccountNumber { get => accountNumber; set => accountNumber = value; }
        protected string Type { get => type; set => type = value; }
        protected int SurchargeDate { get => surchargeDate; set => surchargeDate = value; }
        protected decimal Balance { get => balance; set => balance = value; }


        public abstract void Transfer( decimal amount,Account SpecificAccount );

        public decimal GetBalance() 
        {
            return balance; 
        }

        public void SetBalance(decimal balance)
        {

            this.balance = balance; 
        }


    }
}
