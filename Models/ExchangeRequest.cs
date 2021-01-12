using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeConverter.Models
{
    public class ExchangeRequest
    {
        public int ExchangeRequestId { get; set; }
        public string FromCurrency { get; set; }
        public double FromAmount { get; set; }
        public string ToCorrency { get; set; }
        public double ToAmount { get; set; }
        public string Date { get; set; }

        public ExchangeRequest()
        {
            
        }
        
        public ExchangeRequest(int id, string fromCurrency, double fromAmount, string toCurrency, double toAmount, string date)
        {
            this.ExchangeRequestId = id;
            this.FromCurrency = fromCurrency;
            this.FromAmount = fromAmount;
            this.ToCorrency = toCurrency;
            this.ToAmount = Math.Round(toAmount, 2);
            this.Date = date;
        }
    }
}
