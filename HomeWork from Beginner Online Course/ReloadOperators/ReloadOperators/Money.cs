using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperators
{
    class Money
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Money (double _amount, string _currency)
        {
            Amount = _amount;
            Currency = _currency;
        }
        public static Money operator + (Money first, Money second)
        {
            return new Money(first.Amount + second.Amount,first.Currency);
        }
        public static bool operator != (Money first, Money second)
        {
            if (first.Currency != second.Currency)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator == (Money first, Money second)
        {
            if (first.Currency == second.Currency)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
