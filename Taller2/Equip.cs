using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Equip : Card
    {

        public enum TargetAttribute { AP, RP, ALL }
        public enum Affinity { Knight, Mage, Undead }

        private TargetAttribute targetAttribute;
        private Affinity affinity;
        uint effectPoints;

        internal TargetAttribute TargetAttribute1 { get => targetAttribute; set => targetAttribute = value; }
        internal Affinity Affinity1 { get => affinity; set => affinity = value; }
        public uint EffectPoints { get => effectPoints; set => effectPoints = value; }

        public Equip(string name, lrarety rarety, uint costPoint, TargetAttribute targetAttribute, Affinity affinity, uint effectPoints) : base(name, rarety, costPoint)
        {
            TargetAttribute1 = targetAttribute;
            Affinity1 = affinity;
            EffectPoints = effectPoints;
        }


    }
}
