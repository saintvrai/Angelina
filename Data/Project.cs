using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public int? LineId { get; set; }
        [ForeignKey("LineId")]
        public Line Line { get; set; }

        public int? EffectId { get; set; }
        [ForeignKey("EffectId")]
        public ExternalEffect ExternalEffect { get; set; }

        public int? ExperimentId { get; set; }
        [ForeignKey("ExperimentId")]
        public Experiment Experiment { get; set; }

        public int? ResultId { get; set; }
        [ForeignKey("ResultId")]
        public Result Result { get; set; }

        public int? FirstDeviceId { get; set; }
        [ForeignKey("FirstDeviceId")]
        public ElectricDevice FirstDevice { get; set; }

        public int? SecondDeviceId { get; set; }
        [ForeignKey("SecondDeviceId")]
        public ElectricDevice SecondDevice { get; set; }

        public string Name { get; set; }

    }
}
