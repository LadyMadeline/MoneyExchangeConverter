using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using MoneyExchangeConverter.Services;
using MoneyExchangeConverter.Models;
using MoneyExchangeConverter.Data;

namespace MoneyExchangeConverter.Controllers
{
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        public ExchangeRateAPIService ExchRateService { get; set; }

        public CurrencyController(ExchangeContext context)
        {
            this.ExchRateService = new ExchangeRateAPIService(context);
        }
        
        [HttpGet("/exchange")]
        public double GetRate(double sum, string firstCurrency, string secondCurrency)
        {
            double convertedSum = ExchRateService.GetConvertedSum(sum, firstCurrency, secondCurrency);

            return convertedSum;
        }

        [HttpGet("/history/get")]
        public List<ExchangeRequest> GetHistory()
        {
            List<ExchangeRequest> history = ExchRateService.GetHistoryStorage();
            return history;
        }

        [HttpGet("/history/clean")]
        public void CleanHistory()
        {
            ExchRateService.CleanHistoryStorage();
        }
    }
}
