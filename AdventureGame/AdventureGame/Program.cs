using AdventureGame.Draw;
using AdventureGame.Models;
using System.Text;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CityDrawing city = new CityDrawing();

            Character character = new Character();

            UserInputs.PickingCharacterInputs.PickRace(character);
            UserInputs.PickingCharacterInputs.PickName(character);



            city.Draw();


        }
    }
}
