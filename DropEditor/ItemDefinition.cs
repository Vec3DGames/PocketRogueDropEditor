using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropEditor
{
    class ItemDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Icon { get; set; }
        public bool Stackable { get; set; }
        public string Slot { get; set; }
        public int[] Bonuses { get; set; }
    }
}
