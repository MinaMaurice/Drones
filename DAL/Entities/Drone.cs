using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Drone
    {
        public string SerialNumber { get; set; }
        public ModelType Model { get; set; }
        public decimal Weight { get; set; }
        public Double BatteryCapacity { get; set; }
        public DroneState State { get; set; }
        public List<Medication> Medications { get; set; }
    }

}
