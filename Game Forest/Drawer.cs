using System.Data;

namespace Game_Forest
{
    public class Drawer
    {
        public static void DrawHorizontalLine(Point point, Size size, char symb, char connectSymb, int offsetX = 0, int offsetY = 0)
        {
            Console.SetCursorPosition(point.X, point.Y + offsetY);

            Console.Write(connectSymb);

            for (int i = 0; i < size.Width; i++)
                Console.Write(symb);

            Console.Write(connectSymb);
        }

        public static void DrawVerticalLine(Point point, Size size, char symb, int offsetX = 0, int offsetY = 0)
        {
            for (int i = 1; i < size.Heigth; i++)
            {
                Console.SetCursorPosition(point.X + offsetX, point.Y + i);
                Console.Write(symb);
            }
        }
    }
}
