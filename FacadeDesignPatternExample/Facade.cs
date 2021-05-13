using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternExample
{
    public class Facade
    {
        Bank _bank;
        CentralBank _centralBank;
        Govemment _govemment;
        public Facade()
        {
            _bank = new Bank();
            _centralBank = new CentralBank();
            _govemment = new Govemment();
        }

        public bool TakeBankLoan(Customer customer,decimal amount)
        {
            if(_centralBank.InTheBlackList(customer))
            {
                throw new Exception("You are in the black list");
            }
            if(!_govemment.CheckIncomeEligibility(customer,amount))
            {
                throw new Exception("Your income very poor for this loan");
            }

           return _bank.TakeLoan(customer, amount);
        }
    }
}
