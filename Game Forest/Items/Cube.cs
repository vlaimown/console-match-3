using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Cube : Item
    {
        char horizontalSymb = '-';
        char verticalSymb = '|';
        char connectSymb = '*';

        public Cube(Cell cell, ConsoleColor color = ConsoleColor.Red, int value = 5) : base(cell, color, value)
        {
            base.cell = cell;
            base.color = color;
            base.value = value;
        }
        override public void Draw()
        {
            Console.ForegroundColor = color;

            cell.Rect.Point.X = cell.Rect.Point.X + cell.Rect.Size.Width / 2 - cell.Rect.Size.Width / 4;
            cell.Rect.Point.Y = cell.Rect.Point.Y + cell.Rect.Size.Heigth / 2 - cell.Rect.Size.Heigth / 4;

            cell.Rect.Size.Width = cell.Rect.Size.Width / 2;
            cell.Rect.Size.Heigth = cell.Rect.Size.Heigth / 2;

            Drawer.DrawHorizontalLine(cell.Rect.Point, cell.Rect.Size, horizontalSymb, connectSymb);

            Drawer.DrawVerticalLine(cell.Rect.Point, cell.Rect.Size, verticalSymb, cell.Rect.Size.Width + 1);
            Drawer.DrawVerticalLine(cell.Rect.Point, cell.Rect.Size, verticalSymb);

            Drawer.DrawHorizontalLine(cell.Rect.Point, cell.Rect.Size, horizontalSymb, connectSymb, 0, cell.Rect.Size.Heigth);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
