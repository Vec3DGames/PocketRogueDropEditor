using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropEditor
{
    public class DropDefinition
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int DropRate { get; set; }

        public DropDefinition()
        {

        }

        public DropDefinition(int id, int amount, int dropRate)
        {
            Id = id;
            Amount = amount;
            DropRate = dropRate;
        }
    }
}
