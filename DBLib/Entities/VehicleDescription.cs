using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Entities
{
    public class VehicleDescription
    {
        [Key]
        public string _id { get; set; }
        public string make { get; set; }
        public Int16 year { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public bool hasSunroof { get; set; }
        public bool isFourWheelDrive { get; set; }
        public bool hasLowMiles { get; set; }
        public bool hasPowerWindows { get; set; }
        public bool hasNavigation { get; set; }
        public bool hasHeatedSeats { get; set; }
    }
}
