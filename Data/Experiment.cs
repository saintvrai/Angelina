using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Data
{
    public class Experiment
    {
        [Key]
        public int ExperimentId { get; set; }
        public double MaxFrequency { get; set; }
        public int SourceX { get; set; }
        public int SourceY { get; set; }
        public int SourceZ { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }
        public int VectorZ { get; set; }
    }
}
