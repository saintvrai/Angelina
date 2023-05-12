using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        public int AbsoluteNoise { get; set; } // Абсолютное значение помехи на линии связи
        public int VoltageTimeRelation { get; set; } // Зависимость напряжения от времени
    }
}
