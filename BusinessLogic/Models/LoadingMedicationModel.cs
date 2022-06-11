using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class LoadingMedicationModel
    {
        [Required]
        public string DroneSerialNumber { get; set; }
        [Required]
        public List<string> MedicationCodes { get; set;}
    }
}
