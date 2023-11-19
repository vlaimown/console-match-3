using Game_Forest.Items;
using Game_Forest.GameField;

namespace Game_Forest
{
    class Program
    {
        static void Main()
        {
            GameController controller = new GameController();
            controller.AddItems();
            Field field = new Field(new Cell[8, 8]);
            field.Draw();
            foreach (var itemik in field.GameField)
            {
                Item item = controller.GenerateItem();
                item.Cell = itemik;
                controller.FillCell(itemik, item);
            }

            //Cell cell = new Cell(new Rect(new Point(5, 5), new Size(11, 7)), null);
            //Cell cell2 = new Cell(new Rect(new Point(25, 5), new Size(11, 7)), null);
            //Cell cell3 = new Cell(new Rect(new Point(45, 5), new Size(11, 7)), null);
            //Cell cell4 = new Cell(new Rect(new Point(65, 5), new Size(11, 7)), null);
            //Cell cell5 = new Cell(new Rect(new Point(85, 5), new Size(11, 7)), null);

            //Cube cube = new Cube(cell, ConsoleColor.Red, 5);
            //Triangle triangle = new Triangle(cell2, ConsoleColor.Blue, 5);
            //Rhomb rhomb = new Rhomb(cell3, ConsoleColor.Yellow, 5);
            //Ellipse ellipse = new Ellipse(cell4);
            //Pentagon pentagon = new Pentagon(cell5);

            //cell.Draw();
            //cell2.Draw();
            //cell3.Draw();
            //cell4.Draw();
            //cell5.Draw();

            //cube.Draw();
            //triangle.Draw();
            //rhomb.Draw();
            //ellipse.Draw();
            //pentagon.Draw();

            //Button button = new Button("Play", new Point(10, 10), new Size(50, 10), '|', '-', 'a');
            //button.Draw();

            //Field field = new Field(new Cell[1][1]);
            //field.Draw();

            Console.SetCursorPosition(0, 55);
        }
    }
}