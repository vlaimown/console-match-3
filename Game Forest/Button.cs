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

        override public void Draw()
        {
            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb);

            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, rect.Size.Width + 1);
            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, 0, rect.Size.Heigth);

            Console.SetCursorPosition(rect.Point.X + rect.Size.Width / 2 - text.Length / 2 + 1, rect.Point.Y + rect.Size.Heigth / 2);
            Console.Write(text);
        }
    }
}
