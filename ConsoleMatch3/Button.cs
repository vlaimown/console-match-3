namespace Game_Forest
{
    public class Button : UI
    {
        string text = "";
        public Button(string text, Rect rect, char horizontalSymb = '-', char verticalSymb = '|', char connectSymb = '*') : base(rect, horizontalSymb, verticalSymb, connectSymb)
        {
            this.text = text;
            base.rect = rect;
            base.horizontalSymb = horizontalSymb;
            base.verticalSymb = verticalSymb;
            base.connectSymb = connectSymb;
        }

        override public void Draw(Rect rect, int coef, int offsetY, int offsetX)
        {
            rect.Size.Width = rect.Size.Width / coef;
            rect.Size.Heigth = rect.Size.Heigth / (coef * coef);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, offsetX, offsetY);

            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, rect.Size.Width + 1 + offsetX, offsetY);
            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, 0, offsetY);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, offsetX, rect.Size.Heigth + offsetY);

            Console.SetCursorPosition(rect.Point.X + rect.Size.Width / 2 - text.Length / 2 + 1 + offsetX, rect.Point.Y + rect.Size.Heigth / 2 + offsetY);
            Console.Write(text);
        }
    }
}
