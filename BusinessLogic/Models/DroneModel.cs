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
        [Required]
        [MaxLength(100)]
        public string SerialNumber { get; set; }
        [Required]
        public ModelType Model { get; set; }
        [Range(0, 500)]
        [Required]
        public decimal Weight { get; set; }
        [Required]
        public Double BatteryCapacity { get; set; }
    }
}
