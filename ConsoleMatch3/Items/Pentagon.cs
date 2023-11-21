using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Pentagon : Item
    {
        public Pentagon(Cell cell = null, ConsoleColor color = ConsoleColor.Green, int value = 5) : base(cell, color, value)
        {
            base.cell = cell;
            base.color = color;
            base.value = value;
        }
        override public void Draw()
        {
            Console.ForegroundColor = color;

            int x = cell.Rect.Size.Heigth/2;
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("");
                Console.SetCursorPosition(cell.Rect.Point.X + cell.Rect.Size.Width / 2 - 1, cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 + i - x + 2);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                for (int k = x - 1; k >= i; k--)
                {
                    Console.Write("  ");
                }
                for (int l = i; l >= 1; l--)
                {
                    Console.Write('*');
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
