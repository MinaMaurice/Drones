using BusinessLogic.Models;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MedicationService : IMedicationService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public MedicationService(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public bool RegisterMedication(MedicationModel model)
        {
            try
            {
                _UnitOfWork.MedicationRepository.InsertMedication(new Medication()
                {
                    Weight = model.Weight,
                    Code = model.Code,
                    Image =model.ImageName,
                    Name = model.Name,

                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    
    }
}
