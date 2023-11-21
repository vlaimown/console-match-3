using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Rhomb : Item
    {
        public Rhomb(Cell cell = null, ConsoleColor color = ConsoleColor.Yellow, int value = 5) : base(cell, color, value)
        {
            base.cell = cell;
            base.color = color;
            base.value = value;
        }

        override public void Draw()
        {
            Console.ForegroundColor = color;
            int length = cell.Rect.Size.Heigth / 2;

            for (int i = length; i >= 1; i--)
            {
                Console.Write("");
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 4 + 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + length / 2 - i);

                for (int j = i; j >= 1; j--)
                    Console.Write(" ");
                for (int s = i; s <= length; s++)
                    Console.Write("* ");
            }
            for (int i = length; i >= 1; i--)
            {
                Console.Write("");
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 4 + 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + length / 2 + length - i);

                for (int j = i; j <= length; j++)
                    Console.Write(" ");
                for (int q = i; q >= 1; q--)
                    Console.Write("* ");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
