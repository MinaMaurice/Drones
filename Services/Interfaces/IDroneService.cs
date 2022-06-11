using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDroneService
    {
         bool RegisterDrone(DroneModel model);
        ResponseResuls<string> LoadingMedication(LoadingMedicationModel model);

    }
}
