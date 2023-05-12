using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class ElectricDevice
    {
        [Key]
        public int DeviceId { get; set; }
        public int? X0 { get; set; }
        public int? X1 { get; set; }
        public int? Y0 { get; set; }
        public int? Y1 { get; set; }
        public int? Z0 { get; set; }
        public int? Z1 { get; set; }
    }
}
