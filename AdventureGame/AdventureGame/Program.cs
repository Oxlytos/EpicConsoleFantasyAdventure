using AdventureGame.Models;
using System.Text;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("🫃");
            Console.WriteLine("Pick a race");
            EntityCollection championList = new EntityCollection();
            foreach (var charachter in championList.EntityDictionary)
            {
                Console.WriteLine(charachter.Key + "  " +
                charachter.Value.DisplayMenuName);
            }
            bool userPickInpuit = true;
            while (userPickInpuit)
            {
                int.TryParse(Console.ReadLine(), out int selectedChar);
                switch (selectedChar)
                {
                    case 1:
                        Console.WriteLine(championList.EntityDictionary[selectedChar].DisplayMenuName);
                        userPickInpuit = false;
                        break;

                    case 2:
                        Console.WriteLine("You pressed 2");
                        userPickInpuit = false;

                        break;

                    case 3:
                        Console.WriteLine("You pressed 3");
                        userPickInpuit = false;

                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

        }
    }
}
