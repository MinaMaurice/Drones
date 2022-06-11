using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class MedicationModel
    {
        [Required]
        [RegularExpression(@"^[A-Za-z0-9-_]*$")]
        public string Name { get; set; }
        [Required]
        public decimal Weight { get; set; }
        [RegularExpression(@"^[A-Z0-9_]*$")]
        [Required]
        public string Code { get; set; }
        public string ImageName { get; set; }
    }
}
