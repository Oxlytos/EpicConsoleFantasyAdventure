using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame.Draw
{
    public class CityDrawing
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            // Top
            for (int x = 0; x <= Width + 1; x++)
            {
                Console.Write("H");
            }
            Console.WriteLine();

            // Middle part with walls and empty spaces
            for (int y = 0; y < Height; y++)
            {
                Console.Write("W");
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("W");
            }

            // Bottom
            for (int x = 0; x <= Width + 1; x++)
            {
                Console.Write("H");
            }
        }

    }
}
