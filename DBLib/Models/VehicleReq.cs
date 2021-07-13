using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Models
{
    public class VehicleReq
    {
        public string make { get; set; }
        public Int16 year { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public bool? sunroof { get; set; }
        public bool? fourWheelDrive { get; set; }
        public bool? lowMiles { get; set; }
        public bool? powerWindows { get; set; }
        public bool? navigation { get; set; }
        public bool? heatedSeats { get; set; }
    }
}
