using Game_Forest.GameField;

namespace Game_Forest.Items
{
    public class Item
    {
        protected ConsoleColor color;
        protected int value;

        protected Cell cell;

        public Item(Cell cell, ConsoleColor color = ConsoleColor.White, int value = 0)
        {
            this.color = color;
            this.value = value;
            this.cell = cell;
        }

        virtual public void Draw()
        {

        }

        //public Cell Cell 
        //{ 
        //    get { return cell; }
        //    set { cell = value; }
        //}
    }
}
