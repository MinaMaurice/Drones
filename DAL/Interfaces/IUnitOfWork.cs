using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        public IDroneRepository DroneRepository { get; set; }
        public IMedicationRepository MedicationRepository { get; set; }

    }
}
