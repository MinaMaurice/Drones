﻿using BusinessLogic.Models;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DroneService : IDroneService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public DroneService(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public bool RegisterDrone(DroneModel model)
        {
            try
            {
                _UnitOfWork.DroneRepository.InsertDrone(new Drone()
                {
                    Weight = model.Weight,
                    State = Data.Enums.DroneState.IDLE,
                    SerialNumber = model.SerialNumber,
                    Model = model.Model,
                    BatteryCapacity = model.BatteryCapacity,

                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ResponseResuls<string> LoadingMedication(LoadingMedicationModel model)
        {
            try
            {
                var drone = _UnitOfWork.DroneRepository.GetDrone(model.DroneSerialNumber);
                if (drone != null)
                {
                    if(drone.BatteryCapacity < 25)
                        return new ResponseResuls<string>() { StatusCode = HttpStatusCode.BadRequest, Result = "Drone battery level is below 25 % " };

                    var medications = _UnitOfWork.MedicationRepository.GetMedications(model.MedicationCodes);
                    if (medications.Count > 0)
                    {
                        decimal medicationsWeight = CalculateMedicationsWeight(medications);
                        if (medicationsWeight <= drone.Weight)
                            _UnitOfWork.DroneRepository.AssignMedication(model.DroneSerialNumber, medications);

                        return new ResponseResuls<string>() { StatusCode = HttpStatusCode.BadRequest, Result = "Medications are too Weight" };

                    }
                    return new ResponseResuls<string>() { StatusCode = HttpStatusCode.BadRequest, Result = "Medications Not Exists" };

                }

                return new ResponseResuls<string>() { StatusCode = HttpStatusCode.BadRequest, Result = "Drone Not Exists" };
            }
            catch (Exception ex)
            {
                return new ResponseResuls<string>() { StatusCode = HttpStatusCode.InternalServerError, Result = ex.Message };
            }
        }

        private decimal CalculateMedicationsWeight(List<Medication> Medications)
        {
            return Medications.Sum(m => m.Weight);
        }
    }
}