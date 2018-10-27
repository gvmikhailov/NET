using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperators
{
    class Exchange
    {        
        public static Money CurrencyExchange(Money first, Money second, double rateUSDEUR, double rateUSD, double rateEUR)
        {            
            switch (first.Currency)
            {
                case "USD":
                    {
                        if (second.Currency == "RUB")
                        {
                            second.Amount = Math.Round(second.Amount / rateUSD, 2);
                            return new Money (second.Amount, first.Currency);                            
                        }
                        else if (second.Currency == "EUR")
                        {
                            second.Amount = Math.Round(second.Amount * rateUSDEUR,2);
                            return new Money(second.Amount, first.Currency);
                        }
                        else
                        {
                            return new Money(0, "USD");
                        }
                    }
                case "EUR":
                    {
                        if (second.Currency == "RUB")
                        {
                            second.Amount = Math.Round(second.Amount / rateEUR, 2);
                            return new Money(second.Amount, first.Currency);
                        }
                        else if (second.Currency == "USD")
                        {
                            second.Amount = Math.Round(second.Amount / rateUSDEUR, 2);
                            return new Money(second.Amount, first.Currency);
                        }
                        else
                        {
                            return new Money(0, "EUR");
                        }                                                    
                    }
                case "RUB":
                    {
                        if (second.Currency == "EUR")
                        {
                            second.Amount = Math.Round(second.Amount * rateEUR, 2);
                            return new Money(second.Amount, first.Currency);
                        }
                        else if (second.Currency == "USD")
                        {
                            second.Amount = Math.Round(second.Amount * rateUSD, 2);
                            return new Money(second.Amount, first.Currency);
                        }
                        else
                        {
                            return new Money(0, "RUB");
                        }                        
                    }
                default:
                    {
                        return new Money(0, "RUB");
                    }
            }
            
        }
    }
}
