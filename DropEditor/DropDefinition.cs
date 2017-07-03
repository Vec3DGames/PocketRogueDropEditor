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

        public DropDefinition(int id, int amount, int dropRate)
        {
            this.Id = id;
            this.Amount = amount;
            this.DropRate = dropRate;
        }
    }
}
