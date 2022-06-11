using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class DroneModel
    {
        [MaxLength(100)]
        public string SerialNumber { get; set; }
        public ModelType Model { get; set; }
        [Range(0, 500)]
        public decimal Weight { get; set; }
        public Double BatteryCapacity { get; set; }
    }
}
