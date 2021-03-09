using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Domain.Entities;
using Marketplace.Infrastructure.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Marketplace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapperSession _session;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IMapperSession session)
        {
            _logger = logger;
            _session = session;
        }

        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            var orders = _session.OrderRepository.Orders;
            var users = _session.UserRepository.Users;
            var superOrders = _session.SuperOrderRepository.SuperOrders;

            return superOrders.ToList();
        }
    }
}
