using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Savings : Account
    {
        public Savings(string name, string surname, string accountNumber, int surchargeDate) : base(name, surname, accountNumber, "Savings", surchargeDate, 1000)
        {

        }

        public Savings(string name, string surname, string accountNumber, int surchargeDate, int v) : this(name, surname, accountNumber, surchargeDate)
        {
        }

        public override void Transfer(decimal amount, Account SpecificAccount)
        {
            if (Balance >= amount)
            {
                Balance = amount;
                SpecificAccount.SetBalance(SpecificAccount.GetBalance() = amount);
                Console.WriteLine($"{Name} {Surname} you have transfered {amount} from your {Type} to {Type} account");
            }
            else
            {
                Console.WriteLine("Current account has Insufficent Balance");
            }
        }

        public class ServiceChargeHandler : IServiceCharge
        {
            public void Charge()
            {

            }


        }
    }
    public class ServiceChargeHandler : IServiceCharge
    {
        public void Charge()
        {


        }


    }

}
