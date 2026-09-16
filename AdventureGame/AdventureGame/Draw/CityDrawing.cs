namespace AdventureGame.Draw
{
    public class CityDrawing
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int MinimalSize { get; set; } = 5;
        public int MaximalSize { get; set; } = 25;


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

        public int GetArea(int? width, int? height)
        {
            bool valid = ValidateCitySize(width, height);
            if (valid)
            {
                return width.Value * height.Value;

            }
            throw new ArgumentNullException(nameof(width));
        }

        public int GetMaximalArea()
        {

            return MaximalSize * MaximalSize;
        }

        public int GetMaximalSize()
        {


            return MaximalSize;
        }

        public int GetMinimalArea()
        {
            return MinimalSize * MinimalSize;
        }

        public int GetMinimalSize()
        {
            return MinimalSize;

        }

        public bool ValidateCitySize(int? height, int? width)
        {
            if (height == null || width == null)
            {
                throw new ArgumentNullException(nameof(height), "City dimensions cannot be null");
            }

            if (height <= 0)
            {
                return false;
            }
            if (width <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
