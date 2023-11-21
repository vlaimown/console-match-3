namespace Game_Forest
{
    public class Size
    {
        private int width = 0;
        private int heigth = 0;

        public Size(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }
    }
}
