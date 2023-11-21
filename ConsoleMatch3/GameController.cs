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

        private int horizontalSameItemCount = 0;
        private int verticalSameItemCount = 0;

        private Item nextItem;
        private Item currentItem;
        private Item prevItem;

        private DefeatWindow defeatWindow;

        public GameController(DefeatWindow defeatWindow)
        {
            this.defeatWindow = defeatWindow;
        }
         
        public void Defeat(Rect rect, int coef, int offsetY, int offsetX)
        {
            defeatWindow.Draw(rect, coef, offsetY, offsetX);
        }

        public void AddItems()
        {
            // принимает объекты, которые будут в игре
            items.Add(cube);
            // items.Add(ellipse);
            items.Add(pentagon);
            //items.Add(rhomb);
            //items.Add(triangle);
        }

        public Item GenerateItem(Cell cell)
        {
            Item item = items[random.Next(0, 2)];
            item.Cell = cell;
            return item;
        }

        public void FillCell(Cell cell, Item item)
        {
            cell.Item = item;
        }

        public int HorizontalSameItemCount
        {
            get { return horizontalSameItemCount; }
            set { horizontalSameItemCount = value; }
        }

        public int VerticalSameItemCount
        {
            get { return verticalSameItemCount; }
            set { verticalSameItemCount = value; }
        }

        public bool IsCellEmpty(Cell cell) 
        { 
            if (cell.Item != null)
                return false;
            else
                return true;
        }

        //public Item NextItem
        //{
        //    get { return nextItem; }
        //    set { nextItem = value; }
        //}

        //public Item CurrentItem
        //{
        //    get { return currentItem; }
        //    set { currentItem = value; }
        //}

        //public Item PrevItem
        //{
        //    get { return currentItem; }
        //    set { currentItem = value; }
        //}
    }
}
