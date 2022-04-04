using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    abstract class Card
    {
        public enum lrarety { Common, Rare, SuperRare, UltraRare }

        private string name;
        private lrarety rarety;
        private uint costPoint;

        public string Name { get => name; set => name = value; }
        internal lrarety Rarety { get => rarety; set => rarety = value; }
        public uint CostPoint { get => costPoint; set => costPoint = value; }

        public Card(string name, lrarety rarety, uint costPoint)
        {
            Name = name;
            Rarety = rarety;
            CostPoint = costPoint;
        }
    }
}
