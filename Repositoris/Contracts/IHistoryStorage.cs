using MoneyExchangeConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeConverter.Repositoris.Contracts
{
    public interface IHistoryStorage
    {
        List<ExchangeRequest> GetHistory();
        void AddHistory(string firstCurrency, double sum, string secondCurrency, double convertedSum);
        public void CleanHistory();

    }
}
