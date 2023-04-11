using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern_Character
{
    [Serializable]
    public class Character
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Attack { get; set; }
        public string Abilities { get; set; }
        public string Class { get; set; }
    }
    
}
