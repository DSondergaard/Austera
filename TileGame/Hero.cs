using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using TileGame.Monsters;

namespace TileGame
{
    public class Hero
    {
        public string HeroName { get; set; }
        public Point HeroPosition { get; set; }
        public Tile CurrentLocation { get; set; }
        public Image HeroImage { get; set; }
        
        private Random random { get; set; }

        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackBonus { get; set; }

        public Hero()
        {
            random = new Random();
            MaxHealth = random.Next(20, 30);
            CurrentHealth = MaxHealth;
            MinDamage = 1;
            MaxDamage = 8;
            AttackBonus = 2;
            HeroImage = ImageController.Instance.Hero;
        }

        internal List<string> Attack(Monster _monster)
        {
            List<string> messages = new List<string>();
            int hit = random.Next(20) + 1;
            int damage = 0;
            
            if (hit == 20)
            {
                messages.Add("CRITICAL STRIKE! " + HeroName + " strikes the Monster for a massive attack!");
                damage = random.Next(MinDamage, MaxDamage) + 1;
                damage *= 2;
                messages.Add(HeroName + " deals " + damage + " damage to the monster!");
                goto damageMonster;
            }
            else
                messages.Add("Hero strikes at the Monster with a roll of " + hit);
            hit += AttackBonus;

            if (hit >= _monster.ArmorClass)
            {
                damage = random.Next(MinDamage, MaxDamage) + 1;
                messages.Add(HeroName + " deals " + damage + " damage to the monster!");
            }
            else
                messages.Add(HeroName + " misses the monster.");

        damageMonster:
            _monster.CurrentHealth -= damage;
            if (_monster.CurrentHealth <= 0)
            {
                _monster.CurrentHealth = 0;
                messages.Add("The monster has been slain by " + HeroName + "!");
            }

            return messages;
        }
    }
}
