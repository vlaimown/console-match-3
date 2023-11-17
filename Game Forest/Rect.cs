namespace Game_Forest
{
    public class Rect
    {
        protected Point point = new Point(0, 0);
        protected Size size = new Size(0, 0);

        public Rect(Point point, Size size)
        {
            this.point = point;
            this.size = size;
        }

        public Point Point { get { return point; } }
        public Size Size { get { return size; } }
    }
}
