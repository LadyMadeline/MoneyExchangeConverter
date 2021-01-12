using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoneyExchangeConverter.Models;

namespace MoneyExchangeConverter.Data
{
    public class ExchangeContext : DbContext
    {
        public DbSet<ExchangeRequest> exchangeRequests { get; set; }

        public ExchangeContext(DbContextOptions<ExchangeContext> options)
            : base(options)
        {
        }
    }
}
