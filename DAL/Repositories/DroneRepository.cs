using Data.Entities;
using Data.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class DroneRepository : IDroneRepository
    {
        private List<Drone> drones;

        public DroneRepository(IMemoryCache memoryCache)
        {
            if (!memoryCache.TryGetValue("Drone", out drones))
            {
                drones = new List<Drone>();
                memoryCache.Set("Drone", drones);
            }
        }

        public void InsertDrone(Drone drone)
        {
            var result = drones.Where(e => e.SerialNumber == drone.SerialNumber).SingleOrDefault();
            if (result == null)
                drones.Add(drone);
        }
        public Drone GetDrone(string SerialNumber)
        {
            return drones.Where(e => e.SerialNumber == SerialNumber).SingleOrDefault();
        }


        public List<Drone> GetAvailableDrones()
        {
            return drones.Where(e => e.State == Enums.DroneState.IDLE && e.BatteryCapacity > 25).ToList();
        }
        public void AssignMedication(string DroneSerialNumber, List<Medication> Medications)
        {
            var result = drones.Where(e => e.SerialNumber == DroneSerialNumber).SingleOrDefault();
            if (result != null)
            {
                result.Medications = Medications;
                result.State = Enums.DroneState.LOADED;
            }
        }
    }
}
