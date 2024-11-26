using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGDetector
{
    public class ChildPrediction
    {
        ChildPrediction()
        {
            this.Label = "NotOK";
            this.Score = 0.5f;
        }
        public required string Label { get; set; }
        public required float Score { get; set; }
    }
}
