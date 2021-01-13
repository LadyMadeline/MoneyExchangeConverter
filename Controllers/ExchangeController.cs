using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoneyExchangeConverter.Services;
using MoneyExchangeConverter.Models;
using MoneyExchangeConverter.Data;

namespace MoneyExchangeConverter.Controllers
{
    public class ExchangeController : Controller
    {
        public ExchangeRateAPIService ExchRateService { get; set; }

        public ExchangeController(ExchangeContext context)
        {
            this.ExchRateService = new ExchangeRateAPIService(context);
        }

        [HttpGet("/")]
        public IActionResult GetRate()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult GetRate(double fromAmount, string fromCurrency, string toCurrency)
        {
            double toAmount = ExchRateService.GetConvertedSum(fromAmount, fromCurrency, toCurrency);
            ViewData["fromAmount"] = fromAmount;
            ViewData["toAmount"] = Math.Round(toAmount, 2);
            return View();
        }

        [HttpGet("/history/get")]
        public IActionResult GetHistory()
        {
            List<ExchangeRequest> history = ExchRateService.GetHistoryStorage();
            return View(history);
        }

        [HttpGet("/history/clean")]
        public IActionResult CleanHistory()
        {
            ExchRateService.CleanHistoryStorage();
            List<ExchangeRequest> history = ExchRateService.GetHistoryStorage();
            return View("GetHistory", history);
        }
    }
}
