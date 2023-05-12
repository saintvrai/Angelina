using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class ExternalEffect
    {
        [Key]
        public int EffectId { get; set; }
        public int FieldStrength { get; set; } // напряженность поля
        public int ImpulseDuration { get; set; } // Длительность импульса
        public int ImpulseAmp { get; set; } // Амплитуда импульса
        public int ImpulseStrength { get; set; } // Мощность импульса
        public int IncreaseTime { get; set; } // Время нарастания
        public int DecreaseTime { get; set; } // Время спада
        public int Duration { get; set; } // Время длительности
        public double Frequency { get; set; } // Частота сигнала
    }
}
