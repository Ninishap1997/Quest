using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baksik.Models
{
    public class Rates
    {
        public DateTime Date { get; set; }
        public string PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public string Timestamp { get; set; }
        public int USD { get; set; }
        public int EUR { get; set; }
    }
}
