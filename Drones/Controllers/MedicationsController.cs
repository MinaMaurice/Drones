using BusinessLogic.Models;
using Microsoft.AspNetCore.Http;
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
    public class MedicationsController : ControllerBase
    {
        private readonly ILogger<MedicationsController> _logger;
        private readonly IMedicationService _MedicationService;
        public MedicationsController(ILogger<MedicationsController> logger, IMedicationService MedicationService)
        {
            _logger = logger;
            _MedicationService = MedicationService;
        }


        [HttpPost]
        public IActionResult Register(MedicationModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _MedicationService.RegisterMedication(model);
                    if (result)
                        return StatusCode(StatusCodes.Status200OK, "Medication has been registered successfully");

                    return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong , please try aging later");
                }
                return StatusCode(StatusCodes.Status400BadRequest, "Invalid Model");
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
