using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb7__AI_app_v2
{
    internal class Program
    {
        /*
         * I adapted the suggested approach to fit my project
           and used my own methods to build the character generator.*/
        static void Main(string[] args)
        {
            CharacterGenerator character = new CharacterGenerator();

            List<Character> userCharacters = new List<Character>();
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("\n1. Skapa en karaktär." +
                    "\n2. Visa alla karaktärer." +
                    "\n3. Avsluta.");

                int.TryParse(Console.ReadLine(), out int userMenu);

                switch (userMenu)
                {
                    case 1:
                        Console.WriteLine("Skriv in namn för din hjälte.");


                        Character newCharacter = character.CreateCharacter(Console.ReadLine());
                        string characterName = newCharacter.Name;
                        if (string.IsNullOrWhiteSpace(characterName) || !characterName.All(c => char.IsLetter(c) || c == ' '))
                        {
                            Console.WriteLine("Ogiltigt namn!");
                        }
                        /*
                          * I wanted to make sure that the user could only use letters
                          * and spaces when naming their character.
                          * AI helped me implement this input validation.
                         */

                        else
                        {
                            Console.WriteLine($"Du skapade karaktären, {characterName}!");
                            userCharacters.Add(newCharacter);

                        }


                        break;

                    case 2:

                        if (userCharacters.Count == 0)
                        {
                            Console.WriteLine("Du har inte skapat några karaktärer!");
                        }

                        else
                        {
                            foreach (Character c in userCharacters)
                            {
                                Console.WriteLine($"\nNamn : {c.Name}" +
                                $"\nStyrka : {c.Strength}" +
                                $"\nSnabbhet : {c.Speed}" +
                                $"\nLiv : {c.Health}" +
                                $"\nKlass : {c.Hero}" +
                                $"\nAttack : {c.Ability}");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Du valde att avsluta.");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt alternativ!");
                        break;
                }
            }
        }
    }
}
