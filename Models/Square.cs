using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class Square
    {
        public int SquareId { get; set; }
        public int? NsDistance { get; set; }
        public string Ns { get; set; }
        public int? EwDistance { get; set; }
        public string Ew { get; set; }
    }
}
