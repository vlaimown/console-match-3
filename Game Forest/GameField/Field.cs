namespace Game_Forest.GameField
{
    public class Field
    {
        //Cell[][] field;
        Size size;
        public Field(Size size)
        {
            this.size = size;
        }
        public void Draw()
        {
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Heigth; j++)
                {
                    Cell cell = new Cell(new Rect (new Point(5 * j + j + size.Width, 3 * i + size.Heigth), new Size(5, 3)), null, '-', '|', '*');
                    cell.Draw();
                }
            }
        }
    }
}
