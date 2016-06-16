using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame.Monsters
{
    public class SquidMonster : Monster
    {

        public SquidMonster() : base()
        {
            MaxHealth = random.Next(12, 20);
            CurrentHealth = MaxHealth;
            ArmorClass = random.Next(10, 15);
        }
    }
}
