using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Ellipse : Item
    {
        public Ellipse(Cell cell, ConsoleColor color = ConsoleColor.Magenta, int value = 5) : base(cell, color, value)
        {
            base.cell = cell;
            base.color = color;
            base.value = value;
        }

        override public void Draw()
        {
            Console.ForegroundColor = color;

            int r = cell.Rect.Size.Width / 2 - 3;
            int x = 0;
            for (int y = 0; y <= r; ++y)
            {
                x = (int)Math.Round(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(y, 2)));
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1 + x + r + cell.Rect.Size.Width / 6 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 +  y + r + cell.Rect.Size.Width / 6 - 3);
                Console.Write('.');
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1 + x + r + cell.Rect.Size.Width / 6 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + -y + r + cell.Rect.Size.Width / 6 - 3);
                Console.Write('.');
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1 + -x + r + cell.Rect.Size.Width / 6 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + -y + r + cell.Rect.Size.Width / 6 - 3);
                Console.Write('.');
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1 + -x + r + cell.Rect.Size.Width / 6 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + y + r + cell.Rect.Size.Width / 6 - 3);
                Console.Write('.');
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
