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
            Entitylist championList = new Entitylist();
            foreach (var charachter in championList.entityList)
            {
                Console.WriteLine(charachter.Key + "  " +
                charachter.Value.DisplayMenuName);
            }
            bool userPickInpuit = false;
            while (userPickInpuit)
            {
                int.TryParse(Console.ReadLine(), out int selectedChar);
                switch (selectedChar)
                {
                    case '1':
                        Console.WriteLine(championList.entityList[selectedChar].DisplayMenuName);
                        break;

                    case '2':
                        Console.WriteLine("You pressed 2");
                        break;

                    case '3':
                        Console.WriteLine("You pressed 3");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        userPickInpuit = true;
                        break;
                }
            }

            Thread.Sleep(4000);
        }
    }
}
