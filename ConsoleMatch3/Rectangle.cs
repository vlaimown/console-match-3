namespace Game_Forest
{
    public class Rectangle : UI
    {
        public Rectangle(Rect rect, char horizontalSymb = '-', char verticalSymb = '|', char connectSymb = '*') : base(rect, horizontalSymb, verticalSymb, connectSymb)
        {
            base.rect = rect;
            base.horizontalSymb = horizontalSymb;
            base.verticalSymb = verticalSymb;
            base.connectSymb = connectSymb;
        }

        override public void Draw(Rect rect, int coef, int offsetY, int offsetX)
        {
            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb);

            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, rect.Size.Width + 1);
            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, 0, rect.Size.Heigth);
        }
    }
}
