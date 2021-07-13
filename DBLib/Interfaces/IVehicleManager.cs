using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLib.Entities;
using DBLib.Models;

namespace DBLib.Interfaces
{
    public interface IVehicleManager
    {
        public Task<List<VehicleDescription>> GetVehicles(VsContext context, VehicleReq vReq);
    }
}
