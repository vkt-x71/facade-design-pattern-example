using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternExample
{
    public class Bank
    {
        public bool TakeLoan(Customer customer,decimal amount)
        {
            return true;
        } 
    }
}
