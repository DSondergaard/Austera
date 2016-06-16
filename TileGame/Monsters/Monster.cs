using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame.Monsters
{
    public abstract class Monster
    {
        public Random random;
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int ArmorClass { get; set; }

        public Monster()
        {
            random = new Random();
        }
    }
}
