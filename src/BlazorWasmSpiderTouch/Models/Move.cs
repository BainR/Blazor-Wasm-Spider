using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSpiderTouch.Models
{
    public class Move
    {
        public int FromTableauId { get; set; }
        public int ToPileId { get; set; }
        public bool ToFoundationPile { get; set; }
        public bool TurnFaceDown { get; set; }
        public int Cards { get; set; }
    }
}
