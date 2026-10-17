using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7__AI_app_v2
{
    internal class CharacterGenerator
    {
        Random random = new Random();
        public int GenerateRandomNumber()
        {
            int randomNumber = random.Next(0, 3);

            return randomNumber;
        }
        public Hero GenerateHero()
        {
            /*
             I asked ai to help me with this method.
            I found that the hardest part about this programe was to convert correctily enum to my random class.

             */
            int randomNumber2 = GenerateRandomNumber();

            Hero hero = (Hero)randomNumber2;

            return hero;
        }

        public string HeroAbility(Hero hero)
        {
            if (hero == Hero.Warrior)
            {
                return "Charge";
            }

            else if (hero == Hero.Mage)
            {
                return "Fireball";
            }

            else if (hero == Hero.Rogue)
            {
                return "Strike";
            }

            else
            {
                return "Error";
            }
        }

        public Character CreateCharacter(string characterName)
        {
            Hero hero = GenerateHero();
            string heroAbility = HeroAbility(hero);
            
            int randomStrength = random.Next(1, 101);
            int randomSpeed = random.Next(1, 101);
            int randomHealth = random.Next(1, 101);

            Character character = new Character(characterName, randomStrength, randomSpeed, randomHealth, heroAbility, hero);

            return character;
        }
    }
}
