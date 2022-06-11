using BusinessLogic.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDroneService
    {
        bool RegisterDrone(DroneModel model);
        ResponseResuls<string> LoadingMedication(LoadingMedicationModel model);
        ResponseResuls<List<Medication>> GetDroneMedications(string SerialNumber);
        ResponseResuls<List<Drone>> GetAvailableDrones();
        ResponseResuls<string> GetDroneBatteryLevel(string SerialNumber);

    }
}
