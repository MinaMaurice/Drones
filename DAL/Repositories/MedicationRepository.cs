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
    public class MedicationRepository : IMedicationRepository
    {
        private List<Medication> medications;

        public MedicationRepository(IMemoryCache memoryCache)
        {
            if(!memoryCache.TryGetValue("Medication", out medications))
            {
                medications = new List<Medication>();
                memoryCache.Set("Medication", medications);
            }
        }

        public void InsertMedication(Medication medication)
        {
            medications.Add(medication);
        }

        public List<Medication> GetMedications(List<string> codes)
        {
            return medications.Where(e => codes.Contains(e.Code)).ToList();
        }
    }
}
