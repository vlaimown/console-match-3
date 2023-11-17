using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Triangle : Item
    {
        public Triangle(Cell cell, ConsoleColor color = ConsoleColor.Blue, int value = 5) : base(cell, color, value)
        {
            base.cell = cell;
            base.color = color;
            base.value = value;
        }

        override public void Draw()
        {
            Console.ForegroundColor = color;

            int height = cell.Rect.Size.Heigth / 2;
            Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2);

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(cell.Rect.Point.X + height - i - 1 + cell.Rect.Size.Width / 2 - 1, Console.CursorTop);
                Console.WriteLine(new string('*', i * 2 + 1));
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
