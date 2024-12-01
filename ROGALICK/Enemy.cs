using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogalyha
{
    internal class Enemy
    {
        static Random rnd = new Random();
        static string[] enemyNameList = new string[] { "goblin", "killer", "mops", "troll", "king" };
        public string enemyName = enemyNameList[rnd.Next(0, 5)];
        public int enemyHp = rnd.Next(40, 81);
        public int enemyDamage = rnd.Next(0, 11);

    }
}
