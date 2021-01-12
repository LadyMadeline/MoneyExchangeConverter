using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using MoneyExchangeConverter.Models;
using MoneyExchangeConverter.Repositoris.Contracts;

namespace MoneyExchangeConverter.Repositoris
{
    public class InMemoryHistoryStorage : IHistoryStorage
    {
        private static List<ExchangeRequest> ExchangeHistory { get; set; }

        public InMemoryHistoryStorage()
        {
            if (ExchangeHistory == null)
            {
                ExchangeHistory = new List<ExchangeRequest>();
            }
        }

        public void AddHistory(string firstCurrency, double sum, string secondCurrency, double convertedSum)
        {
            int id = ExchangeHistory.Count;
            string date = DateTime.Today.ToShortDateString();
            ExchangeRequest request = new ExchangeRequest(id, firstCurrency, sum, secondCurrency, convertedSum, date);
            ExchangeHistory.Add(request);
        }

        public List<ExchangeRequest> GetHistory()
        {
            return ExchangeHistory;
        }

        public void CleanHistory()
        {
            throw new NotImplementedException();
        }
    }
}
