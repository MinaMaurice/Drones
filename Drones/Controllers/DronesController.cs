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
    public class DronesController : ControllerBase
    {
        private readonly ILogger<DronesController> _logger;
        private readonly IDroneService _DroneService;
        public DronesController(ILogger<DronesController> logger, IDroneService DroneService)
        {
            _logger = logger;
            _DroneService = DroneService;
        }


        [HttpPost]
        public IActionResult Register(DroneModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _DroneService.RegisterDrone(model);
                    if (result)
                        return StatusCode(StatusCodes.Status200OK, "Drone has been registered successfully");

                    return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong , please try aging later");
                }
                return StatusCode(StatusCodes.Status400BadRequest, "Invalid Model");
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpPost]
        [Route("LoadingMedication")]

        public IActionResult LoadingMedication(LoadingMedicationModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _DroneService.LoadingMedication(model);
                    return StatusCode((int)result.StatusCode,result.Result);
                }
                return StatusCode(StatusCodes.Status400BadRequest, "Invalid Model");
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("GetDroneMedications")]
        public IActionResult GetDroneMedications(string SerialNumber)
        {
            try
            {
                if (!string.IsNullOrEmpty(SerialNumber))
                {
                    var result = _DroneService.GetDroneMedications(SerialNumber);
                    return StatusCode((int)result.StatusCode, result.Result);
                }
                return StatusCode(StatusCodes.Status400BadRequest, "Invalid Model");
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAvailableDrones ")]
        public IActionResult GetAvailableDrones()
        {
            try
            {
                    var result = _DroneService.GetAvailableDrones();
                    return StatusCode((int)result.StatusCode, result.Result);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
