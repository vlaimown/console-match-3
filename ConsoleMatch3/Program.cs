using Game_Forest.Items;
using Game_Forest.GameField;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace Game_Forest
{
    class Program
    {
        char[,] gameSpace = new char[5000,5000];
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out CursorPos lpPoint);
        public struct CursorPos { public int X; public int Y; }

        static void TimerWork()
        {
            Timer timer = new Timer();
            Button defeatConfirmButton = new Button("OK", new Rect(new Point(5, 5), new Size(10, 10)));
            DefeatWindow defeat = new DefeatWindow(defeatConfirmButton, "GAME OVER", new Rect(new Point(8, 8), new Size(25, 25)));
            GameController controller = new GameController(defeat);
            controller.AddItems();

            //Console.SetCursorPosition(0, 0);
            
            //timer.TimeTick();
            //if (timer.TimeTick() <= 0)
            //    controller.Defeat(defeat.Rect, 3, 20, 10);
        }

        static void PlayerInput()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
        }

        static void Main()
        {
            CursorPos position;

            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;


            Console.WriteLine();
            Console.WriteLine();

            Button button = new Button("Play", new Rect(new Point(10, 10), new Size(50, 10)), '|', '-', 'a');
            button.Draw(button.Rect, 1, 0, 0);

            ThreadStart timerThread = new ThreadStart(PlayerInput);
            Thread thread1 = new Thread(timerThread);
            thread1.Start();

            while (true)
            {
                if (GetCursorPos(out position))
                {
                    //if (Console.)
                    //{

                    //}
                    //if (Console.KeyAvailable)
                    //{
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine($"{position.X},{position.Y}");
                    Console.WriteLine($"{button.Rect.Point.X},{button.Rect.Point.Y}");
                    if (position.X >= button.Rect.Point.X * 8 && position.X <= button.Rect.Size.Width*10 && position.Y >= button.Rect.Point.Y * 20 && position.Y <= button.Rect.Size.Heigth *35)
                    {
                        Console.SetCursorPosition(0,10);
                        Console.WriteLine("aaa");
                        //if (e.KeyCode == Keys.Enter)
                        //{
                        //    Console.SetCursorPosition(0, 5);
                        //    Console.Write("    ");
                        //    Console.SetCursorPosition(0, 5);
                        //    Console.WriteLine("YES!");
                        //}
                     }
                }
            }

            Field field = new Field(new Cell[8, 8]);
            field.Draw();

            Random random = new Random();

            //for (int i = 0; i < field.GameField.GetLength(0); i++)
            //{
            //    for (int j = 0; j < field.GameField.GetLength(1); j++)
            //    {
            //        //Cube cube = new Cube(field.GameField[i, j]);
            //        //Pentagon pentagon = new Pentagon(field.GameField[i, j]);
            //        Rhomb rhomb = new Rhomb(field.GameField[i, j]);
            //        Triangle triangle = new Triangle(field.GameField[i, j]);

            //        Item[] arr = { /*cube, pentagon,*/ rhomb, triangle };

            //        Item item = arr[random.Next(0, arr.Length)];

            //        field.GameField[i, j].Item = item;
            //    }
            //}

            //for (int i = 0; i < field.GameField.GetLength(0); i++)
            //{
            //    for (int j = 0; j < field.GameField.GetLength(1); j++)
            //    {
            //        field.GameField[i, j].Item.Draw();
            //    }
            //}
            for (int i = 0; i < field.GameField.GetLength(0); i++)
            {
                for (int j = 0; j < field.GameField.GetLength(1); j++)
                {
                    //Cube cube = new Cube(field.GameField[i, j]);
                    //Pentagon pentagon = new Pentagon(field.GameField[i, j]);
                    Rhomb rhomb = new Rhomb(field.GameField[i, j]);
                    Triangle triangle = new Triangle(field.GameField[i, j]);

                    Item[] arr = { /*cube, pentagon,*/ rhomb, triangle };

                    Item item = arr[random.Next(0, arr.Length)];

                    field.GameField[i, j].Item = item;
                }
            }

            ////for (int i = 0; i < field.GameField.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < field.GameField.GetLength(1); j++)
            ////    {
            ////        Rhomb rhomb = new Rhomb(field.GameField[i, j]);
            ////        Triangle triangle = new Triangle(field.GameField[i, j]);

            ////        Item currentItem = null;
            ////        Item leftItem = null;
            ////        Item rightItem = null;
            ////        Item topItem = null;
            ////        Item bottomItem = null;

            ////        Item[] arr = { rhomb, triangle };

            ////        if (i == 0 && j + 1 < field.GameField.GetLength(1) && j - 1 >= 0)
            ////        {
            ////            currentItem = field.GameField[i, j].Item;
            ////            leftItem = field.GameField[i, j - 1].Item;
            ////            rightItem = field.GameField[i, j + 1].Item;

            ////            if (leftItem.GetType() == rightItem.GetType())
            ////            {
            ////                if (currentItem.GetType() == leftItem.GetType())
            ////                {
            ////                    Item item = arr[random.Next(0, arr.Length)];

            ////                    while (currentItem.GetType() == item.GetType())
            ////                        item = arr[random.Next(0, arr.Length)];

            ////                    field.GameField[i, j].Item = item;
            ////                }
            ////            }
            ////        }

            ////        if (i + 1 < field.GameField.GetLength(0) && i - 1 >= 0 && j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
            ////        {
            ////            currentItem = field.GameField[i, j].Item;
            ////            leftItem = field.GameField[i, j - 1].Item;
            ////            rightItem = field.GameField[i, j + 1].Item;
            ////            topItem = field.GameField[i + 1, j].Item;
            ////            bottomItem = field.GameField[i - 1, j].Item;

            ////            if (leftItem.GetType() == rightItem.GetType() && topItem.GetType() != bottomItem.GetType())
            ////            {
            ////                if (currentItem.GetType() == leftItem.GetType())
            ////                {
            ////                    Item item = arr[random.Next(0, arr.Length)];

            ////                    while (currentItem.GetType() == item.GetType())
            ////                        item = arr[random.Next(0, arr.Length)];

            ////                    field.GameField[i, j].Item = item;
            ////                }
            ////            }

            ////            else if (leftItem.GetType() != rightItem.GetType() && topItem.GetType() == bottomItem.GetType())
            ////            {
            ////                if (currentItem.GetType() == topItem.GetType())
            ////                {
            ////                    Item item = arr[random.Next(0, arr.Length)];

            ////                    while (currentItem.GetType() == item.GetType())
            ////                        item = arr[random.Next(0, arr.Length)];

            ////                    field.GameField[i, j].Item = item;
            ////                }
            ////            }

            ////            else if (leftItem.GetType() == rightItem.GetType() && topItem.GetType() == bottomItem.GetType())
            ////            {
            ////                if (currentItem.GetType() == topItem.GetType() || currentItem.GetType() == rightItem.GetType())
            ////                {
            ////                    Item item = arr[random.Next(0, arr.Length)];
            ////                    int countTry = arr.Length;
            ////                    for (int c = 0; c < arr.Length; c++)
            ////                    {
            ////                        item = arr[random.Next(0, countTry)];
            ////                        if (topItem.GetType() != item.GetType() && leftItem.GetType() != item.GetType())
            ////                        {
            ////                            field.GameField[i, j].Item = item;
            ////                            break;
            ////                        }
            ////                        countTry -= 1;
            ////                    }
            ////                    field.GameField[i, j].Item = arr[random.Next(0, arr.Length)];

            ////                }

            ////                else if (currentItem.GetType() == topItem.GetType() && currentItem.GetType() == rightItem.GetType())
            ////                {
            ////                    Item item = arr[random.Next(0, arr.Length)];
            ////                    while (currentItem.GetType() == item.GetType())
            ////                        item = arr[random.Next(0, arr.Length)];
            ////                }
            ////            }
            ////        }
            ////        field.GameField[i, j].Item.Draw();
            ////    }
            ////}

            //Cell cell = new Cell(new Rect(new Point(5, 5), new Size(11, 7)), null);
            //Cell cell2 = new Cell(new Rect(new Point(25, 5), new Size(11, 7)), null);
            //Cell cell3 = new Cell(new Rect(new Point(45, 5), new Size(11, 7)), null);
            //Cell cell4 = new Cell(new Rect(new Point(65, 5), new Size(11, 7)), null);
            //Cell cell5 = new Cell(new Rect(new Point(85, 5), new Size(11, 7)), null);

            ////Cube cube = new Cube(cell, ConsoleColor.Red, 5);
            ////Triangle triangle = new Triangle(cell2, ConsoleColor.Blue, 5);
            ////Rhomb rhomb = new Rhomb(cell3, ConsoleColor.Yellow, 5);
            ////Ellipse ellipse = new Ellipse(cell4);
            ////Pentagon pentagon = new Pentagon(cell5);

            ////cell.Draw();
            ////cell2.Draw();
            ////cell3.Draw();
            ////cell4.Draw();
            ////cell5.Draw();

            ////cube.Draw();
            ////triangle.Draw();
            ////rhomb.Draw();
            ////ellipse.Draw();
            ////pentagon.Draw();

            ////Button button = new Button("Play", new Point(10, 10), new Size(50, 10), '|', '-', 'a');
            ////button.Draw();

            ////Field field = new Field(new Cell[1][1]);
            ////field.Draw();
            ///

            Console.SetCursorPosition(0, 50);
        }
    }
}