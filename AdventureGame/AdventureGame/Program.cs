using AdventureGame.Models;
using System.Text;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Character character = new Character();

            var race = UserInputs.PickingCharacterInputs.PickRace();

        }
    }
}
