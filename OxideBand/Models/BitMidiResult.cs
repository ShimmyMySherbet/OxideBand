using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxideBand.Models
{
    public class BitMidiResult
    {
        public BitMidiQuery query;
        public List<BitMidiResultEntry> results;
        public int total;
        public int pageTotal;
    }
}
