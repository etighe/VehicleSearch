using DBLib;
using DBLib.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DBLib.Interfaces;
using DBLib.Managers;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleDescriptionsController : ControllerBase
    {
        private readonly VsContext _context;
        private readonly IVehicleManager _vMgr;

        public VehicleDescriptionsController(VsContext context, IVehicleManager vMgr)
        {
            _context = context;
            _vMgr = vMgr;
        }


        // GET: api/Vehicles/{\"hasSunroof\" : true}
        [HttpGet("{req}")]
        [EnableCors("myOrigins")]
        [AllowAnonymous]
        public async Task<ActionResult<List<VehicleDescription>>> GetVehicles(string req)
       {

            var vReq = JsonSerializer.Deserialize<DBLib.Models.VehicleReq>(req);

            var vehicleList = await _vMgr.GetVehicles(_context, vReq);

            if (vehicleList != null && vehicleList.Count <= 0)
            {
                return new EmptyResult(); 
            }

            if (vehicleList == null)
            {
                return NotFound();
            }

            return vehicleList;
        }

        #region Scaffold Code for future

        //// PUT: api/VehicleDescriptions/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutVehicleDescription(string id, VehicleDescription vehicleDescription)
        //{
        //    if (id != vehicleDescription._id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(vehicleDescription).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!VehicleDescriptionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/VehicleDescriptions
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<VehicleDescription>> PostVehicleDescription(VehicleDescription vehicleDescription)
        //{
        //    _context.Vehicles.Add(vehicleDescription);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (VehicleDescriptionExists(vehicleDescription._id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetVehicleDescription", new { id = vehicleDescription._id }, vehicleDescription);
        //}

        //// DELETE: api/VehicleDescriptions/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteVehicleDescription(string id)
        //{
        //    var vehicleDescription = await _context.Vehicles.FindAsync(id);
        //    if (vehicleDescription == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Vehicles.Remove(vehicleDescription);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        #endregion Scaffold Code for future

        private bool VehicleDescriptionExists(string id)
        {
            return _context.Vehicles.Any(e => e._id == id);
        }
    }
}
