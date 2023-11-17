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

        virtual public void Draw() { }

        public Rect Rect { get { return rect; } }
    }
}
