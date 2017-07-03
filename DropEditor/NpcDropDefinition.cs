using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropEditor
{
    /// <summary>
    /// Defines the shell of a NPC's drops for the JSON converter.
    /// </summary>
    public class NpcDropDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DropDefinition> Drops { get; set; }

        public NpcDropDefinition()
        {

        }

        public NpcDropDefinition(int id, string name, List<DropDefinition> drops)
        {
            Id = id;
            Name = name;
            Drops = drops;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
