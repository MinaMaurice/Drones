using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DispatchController : ControllerBase
    {
        private readonly ILogger<DispatchController> _logger;
        private readonly IDroneService _DroneService;
        public DispatchController(ILogger<DispatchController> logger , IDroneService DroneService)
        {
            _logger = logger;
            _DroneService = DroneService;
        }



    }
}
