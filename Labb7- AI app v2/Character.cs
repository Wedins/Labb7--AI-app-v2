using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7__AI_app_v2
{
    internal class Character
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string Ability { get; set; }
        public  Hero Hero { get; set; }
        public Character(string name, int strength, int speed, int health, string ability, Hero hero)
        {
            Name = name;
            Strength = strength;
            Speed = speed;
            Health = health;
            Ability = ability;
            Hero = hero;
        }
    }
}
