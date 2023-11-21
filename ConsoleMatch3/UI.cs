using System.Drawing;

namespace Game_Forest
{
    public class UI
    {
        protected Rect rect;

        protected char horizontalSymb;
        protected char verticalSymb;
        protected char connectSymb;

        protected Drawer drawer = new Drawer();

        public UI(Rect rect, char horizontalSymb = '-', char verticalSymb = '|', char connectSymb = '*')
        {
            this.rect = rect;
            this.horizontalSymb = horizontalSymb;
            this.verticalSymb = verticalSymb;
            this.connectSymb = connectSymb;
        }

        public void ClearZone(Rect rect, int offsetX, int offsetY)
        {
            Console.SetCursorPosition(rect.Point.X + offsetX, rect.Point.Y + offsetY);
            for (int i = 0; i < rect.Size.Heigth; i++)
            {
                for (int j = 0; j < rect.Size.Width; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        virtual public void Draw(Rect rect, int coef, int offsetY, int offsetX) { }

        public Rect Rect { get { return rect; } }
    }
}
