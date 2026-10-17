namespace Labb7__AI_app_v2
{
    internal class Program
    {
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
                        userCharacters.Add(newCharacter);

                        break;

                    case 2:

                        if(userCharacters.Count == 0)
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
                        Console.WriteLine("Avsluta");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Ogiligt!");
                        break;
                }
            }
        }
    }
}
