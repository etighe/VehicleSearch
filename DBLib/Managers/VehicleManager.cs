using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLib.Entities;
using DBLib.Interfaces;
using DBLib.Models;
using Microsoft.EntityFrameworkCore;

namespace DBLib.Managers
{
    public class VehicleManager : IVehicleManager
    {
        public async Task<List<VehicleDescription>> GetVehicles(VsContext context, VehicleReq vReq)
        {
            try
            {
                var vehicleList = await context.Vehicles.Where(x =>
                    (x.hasSunroof == vReq.sunroof || vReq.sunroof == null)
                    && (x.isFourWheelDrive == vReq.fourWheelDrive || vReq.fourWheelDrive == null)
                    && (x.hasLowMiles == vReq.lowMiles || vReq.lowMiles == null)
                    && (x.hasPowerWindows == vReq.powerWindows || vReq.powerWindows == null)
                    && (x.hasNavigation == vReq.navigation || vReq.navigation == null)
                    && (x.hasHeatedSeats == vReq.heatedSeats || vReq.heatedSeats == null)
                ).ToListAsync();

                return vehicleList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
