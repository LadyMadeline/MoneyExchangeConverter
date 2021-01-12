using MoneyExchangeConverter.Data;
using MoneyExchangeConverter.Models;
using MoneyExchangeConverter.Repositoris.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeConverter.Repositoris
{
    public class SQLHistoryStorage : IHistoryStorage
    {
        public ExchangeContext Context { get; set; }

        public SQLHistoryStorage(ExchangeContext context)
        {
            this.Context = context;
        }

        public void AddHistory(string firstCurrency, double sum, string secondCurrency, double convertedSum)
        {
            string date = DateTime.Today.ToShortDateString();
            ExchangeRequest exchangeRequest = new ExchangeRequest(0, firstCurrency, sum, secondCurrency, convertedSum, date);
            Context.Add<ExchangeRequest>(exchangeRequest);
            Context.SaveChanges();
        }

        public List<ExchangeRequest> GetHistory()
        {
            return Context.exchangeRequests.ToList();
        }

        public void CleanHistory()
        {
            foreach (ExchangeRequest item in Context.exchangeRequests)
            {
                Context.exchangeRequests.Remove(item);
            }

            Context.SaveChanges();
        }
    }
}
