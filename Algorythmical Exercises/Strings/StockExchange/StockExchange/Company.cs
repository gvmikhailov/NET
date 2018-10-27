using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    class Company
    {
        internal readonly static List<Company> companies = new List<Company>();

        internal static List<Company> selectedCompanies = new List<Company>();

        public string ShortName { get; set; }
        public string FullName { get; set; }
        public double LastOld { get; set; }
        public double LastNew { get; set; }
        public char Arrow { get; set; }

        internal Company(string shortName, string fullName)
        {
            ShortName = shortName;
            FullName = fullName;
            companies.Add(this);
        }

        internal Company(string shortName, string fullName, double lastOld, double lastNew, char arrow)
        {
            ShortName = shortName;
            FullName = fullName;
            LastNew = lastNew;
            LastOld = lastOld;
            Arrow = arrow;
            selectedCompanies.Add(this);
        }
    }
}
