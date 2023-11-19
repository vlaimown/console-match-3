using Game_Forest.Items;
using Game_Forest.GameField;
using System.Reflection.Metadata.Ecma335;

namespace Game_Forest
{
    public class GameController
    {
        Cube cube = new Cube();
        Ellipse ellipse = new Ellipse();
        Pentagon pentagon = new Pentagon();
        Rhomb rhomb = new Rhomb();
        Triangle triangle = new Triangle();

        List<Item> items = new List<Item>(5);
        Random random = new Random();

        public void AddItems()
        {
            // принимает объекты, которые будут в игре
            items.Add(cube);
           // items.Add(ellipse);
            items.Add(pentagon);
            items.Add(rhomb);
            items.Add(triangle);
        }

        public Item GenerateItem()
        {
            Item item = items[random.Next(0, 4)];
            return item;
        }

        public void FillCell(Cell cell, Item item)
        {
            cell.Item = item;
            cell.Item.Draw();
        }
    }
}
