using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class Line
    {
        [Key]
        public int LineId { get; set; }
        public int BodyMaterialResistance { get; set; } // сопротивление материала корпуса
        public int X1max { get; set; }
        public int X2min { get; set; }
        public int ConductorRadius { get; set; } // рад. жилы
        public int InsulationRadius { get; set; } // рад. изоляции
    }
}
