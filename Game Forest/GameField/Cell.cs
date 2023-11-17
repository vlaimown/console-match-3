using Game_Forest.Items;

namespace Game_Forest.GameField
{
    public class Cell
    {
        Rect rect;
        Item item;
        Drawer drawer = new Drawer();
        //Rectangle rectangle;

        char horizontalSymb;
        char verticalSymb;
        char connectSymb;

        public Cell(Rect rect, Item item, char horizontalSymb = '-', char verticalSymb = '|', char connectSymb = '*')
        {
            this.rect = rect;
            this.item = item;
            this.horizontalSymb = horizontalSymb;
            this.verticalSymb = verticalSymb;
            this.connectSymb = connectSymb;
            //this.rectangle = new Rectangle(rect);
        }

        public void Draw()
        {
            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb);

            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, rect.Size.Width + 1);
            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, 0, rect.Size.Heigth);
        }

        public Rect Rect { get { return rect; } }

        public Item Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
