using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IMedicationRepository
    {
        void  InsertMedication(Medication medication);
         List<Medication> GetMedications(List<string> codes);

    }
}
