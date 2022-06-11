using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Enums
{
    public enum DroneState
    {
        IDLE = 0,
        LOADING = 1, 
        LOADED = 2, 
        DELIVERING = 3, 
        DELIVERED = 4, 
        RETURNING = 5
    }
}
