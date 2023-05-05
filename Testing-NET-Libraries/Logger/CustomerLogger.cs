using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_NET_Libraries.Logger.Models;

namespace Testing_NET_Libraries.Logger
{
    internal class CustomerLogger
    {
        private readonly ILogger<CustomerLogger> _logger;


        public CustomerLogger(ILogger<CustomerLogger> logger)
        {
            _logger = logger;
        }

        public void logCustomerData(Customer customer)
        {
            _logger.LogInformation($"Customer N°{customer.Id}", customer.ToString());
        }
    }
}
