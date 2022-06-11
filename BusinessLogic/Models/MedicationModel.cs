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
        [RegularExpression(@"^[A-Za-z0-9-_]*$")]
        public string Name { get; set; }
        public decimal Weight { get; set; }
        [RegularExpression(@"^[A-Z0-9_]*$")]
        public string Code { get; set; }
        public string ImageName { get; set; }
    }
}
