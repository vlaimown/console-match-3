namespace Game_Forest.GameField
{
    public class Field
    {
        private Cell[,] gameField;
        public Field(Cell[,] field)
        {
            this.gameField = field;
        }
        public void Draw()
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Cell cell = new Cell(new Rect (new Point(8 * j + j + gameField.GetLength(0), 5 * i + gameField.GetLength(1)), new Size(8, 5)), null, '-', '|', '*');
                    gameField[i, j] = cell;
                    cell.Draw();
                }
            }
        }
        public Cell[,] GameField
        {
            get { return gameField; }
        }
    }
}
