namespace Game_Forest
{
    public class DefeatWindow : UI
    {
        private string text = "";
        private Button button;
        public DefeatWindow(Button button, string text, Rect rect, char horizontalSymb = '-', char verticalSymb = '|', char connectSymb = '*') : base(rect, horizontalSymb, verticalSymb, connectSymb)
        {
            this.button = button;
            this.text = text;
            base.rect = rect;
            base.horizontalSymb = horizontalSymb;
            base.verticalSymb = verticalSymb;
            base.connectSymb = connectSymb;
        }

        override public void Draw(Rect rect, int coef, int offsetY, int offsetX)
        {
            for (int i = 0; i < rect.Size.Heigth; i++)
            {
                for (int j = 0; j < rect.Size.Width; j++)
                {
                    Console.SetCursorPosition(rect.Point.X + j, rect.Point.Y + 1 + i);
                    Console.WriteLine(" ");
                }
            }

            Console.SetCursorPosition(rect.Point.X + rect.Size.Width / 2 - text.Length / 2 + 1, rect.Point.Y + rect.Size.Heigth / 2);
            Console.Write(text);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb);

            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb, rect.Size.Width + 1);
            Drawer.DrawVerticalLine(rect.Point, rect.Size, verticalSymb);

            Drawer.DrawHorizontalLine(rect.Point, rect.Size, horizontalSymb, connectSymb, 0, rect.Size.Heigth);

            button.Draw(rect, coef, offsetY, offsetX);
        }
    }
}
