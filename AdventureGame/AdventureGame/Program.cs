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
            foreach (var charachter in championList.EntityList)
            {
                Console.WriteLine(charachter.Key + "  " +
                charachter.Value.DisplayMenuName);
            }


        }
    }
}
