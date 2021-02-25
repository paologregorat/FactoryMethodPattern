﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethodPattern.Businesslogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FactoryMethodPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            new Client().Main();
        }
    }
}
