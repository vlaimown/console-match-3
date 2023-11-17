using Game_Forest.Items;
using Game_Forest.GameField;

namespace Game_Forest
{
    public class GameController
    {
        //Cube cube = new Cube(new Point(10,10), new Size(10, 3), ConsoleColor.Blue, 5);
        //Ellipse ellipse = new Ellipse(new Point(10,10), new Size(10, 3), ConsoleColor.Blue, 5);
        //Pentagon pentagon = new Pentagon(new Point(10,10), new Size(10, 3), ConsoleColor.Blue, 5);
        //Rhomb rhomb = new Rhomb(new Point(10,10), new Size(10, 3), ConsoleColor.Blue, 5);
        //Triangle triangle = new Triangle(new Point(10,10), new Size(10, 3), ConsoleColor.Blue, 5);

        List<Item> items = new List<Item>();
        Random random = new Random();

        public void AddItems()
        {
            // принимает объекты, которые будут в игре
            //items.Add(cube);
            //items.Add(ellipse);
            //items.Add(pentagon);
            //items.Add(rhomb);
            //items.Add(triangle);
        }

        public Item GenerateItem()
        {
            Item item = items[random.Next(0, 1-1)];
            return item;
        }

        public void FillCell(Cell cell, Item item)
        {
            cell.Item = item;
            cell.Item.Draw();
        }
    }
}
