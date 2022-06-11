using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IDroneRepository
    {
        void InsertDrone(Drone drone);
        Drone GetDrone(string SerialNumber);
        void AssignMedication(string DroneSerialNumber, List<Medication> Medications);
        List<Drone> GetAvailableDrones();

    }
}
