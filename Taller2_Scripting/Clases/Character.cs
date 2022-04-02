using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Scripting.Clases
{
    public enum laffinitys { Knight, Mage, Undead }

    class Character : Card
    {
        private uint attackPoints;
        private uint resistPoints;
        private List<Equip> lequips;
        private laffinitys affinity;


        public Character(string name, lrarety rarety, uint costPoint, uint attackPoints, uint resistPoints, List<Equip> lequips, laffinitys affinity) : base(name, rarety, costPoint)
        {
            AttackPoints = attackPoints;
            ResistPoints = resistPoints;
            Lequips = lequips;
            Affinity = affinity;
        }

        public uint AttackPoints { get => attackPoints; set => attackPoints = value; }
        public uint ResistPoints { get => resistPoints; set => resistPoints = value; }
        public laffinitys Affinity { get => affinity; set => affinity = value; }
        internal List<Equip> Lequips { get => lequips; set => lequips = value; }
    }
}
