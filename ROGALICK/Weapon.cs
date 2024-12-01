using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogalyha
{
    internal class Weapon
    {
        static Random rnd = new Random();
        static string[] weaponNameList = new string[] { "Hot blade", "Red fire", "Mia", "Alucard", "balmond", "daedalus", "The call of the wind", "diamond sworld" };
        public string weaponName = weaponNameList[rnd.Next(0, 8)];
        public int damage = rnd.Next(10, 61);
    }
}
