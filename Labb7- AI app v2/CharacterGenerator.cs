using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7__AI_app_v2
{
    internal class CharacterGenerator
    {
        /*
       * I adapted the suggested approach to fit my project
         and used my own methods to build the character generator.*/

        /*
         AI helped me develop the CharacterGenerator class.
         I used AI assistance to understand how to generate random
         character attributes, select a random Hero enum value,
         and assign a special ability based on the character class.
         */
        Random random = new Random();
        public int GenerateRandomNumber()
        {
            int randomNumber = random.Next(0, 3);

            return randomNumber;
        }
        public Hero GenerateHero()
        {
            /*
          AI helped me understand how to convert a random integer
          into a Hero enum value.
          I used this approach to randomly select a character class.
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
            /* AI helped me create this method by showing me how to
               use my existing methods together to generate a character. 
             */

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
