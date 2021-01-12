using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeConverter.Models
{
    public class CurrencyRateList
    {
        public Dictionary<string, double> rates { get; set; }
        public DateTime date { get; set; }
    }
}
