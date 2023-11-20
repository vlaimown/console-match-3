using Game_Forest.Items;
using Game_Forest.GameField;

namespace Game_Forest
{
    class Program
    {
        static void Main()
        {
            GameController controller = new GameController();
            controller.AddItems();

            Field field = new Field(new Cell[8, 8]);
            field.Draw();

            Random random = new Random();

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

            for (int i = 0; i < field.GameField.GetLength(0); i++)
            {
                for (int j = 0; j < field.GameField.GetLength(1); j++)
                {
                    Rhomb rhomb = new Rhomb(field.GameField[i, j]);
                    Triangle triangle = new Triangle(field.GameField[i, j]);

                    Item currentItem = null;
                    Item leftItem = null;
                    Item rightItem = null;
                    Item topItem = null;
                    Item bottomItem = null;

                    Item[] arr = { rhomb, triangle };

                    if (i == 0 && j + 1 < field.GameField.GetLength(1) && j - 1 >= 0)
                    {
                        currentItem = field.GameField[i, j].Item;
                        leftItem = field.GameField[i, j - 1].Item;
                        rightItem = field.GameField[i, j + 1].Item;

                        if (leftItem.GetType() == rightItem.GetType())
                        {
                            if (currentItem.GetType() == leftItem.GetType())
                            {
                                Item item = arr[random.Next(0, arr.Length)];

                                while (currentItem.GetType() == item.GetType())
                                    item = arr[random.Next(0, arr.Length)];

                                field.GameField[i, j].Item = item;
                            }
                        }
                    }

                    if (i + 1 < field.GameField.GetLength(0) && i - 1 >= 0 && j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
                    {
                        currentItem = field.GameField[i, j].Item;
                        leftItem = field.GameField[i, j - 1].Item;
                        rightItem = field.GameField[i, j + 1].Item;
                        topItem = field.GameField[i + 1, j].Item;
                        bottomItem = field.GameField[i - 1, j].Item;

                        if (leftItem.GetType() == rightItem.GetType() && topItem.GetType() != bottomItem.GetType())
                        {
                            if (currentItem.GetType() == leftItem.GetType())
                            {
                                Item item = arr[random.Next(0, arr.Length)];

                                while (currentItem.GetType() == item.GetType())
                                    item = arr[random.Next(0, arr.Length)];

                                field.GameField[i, j].Item = item;
                            }
                        }

                        else if (leftItem.GetType() != rightItem.GetType() && topItem.GetType() == bottomItem.GetType())
                        {
                            if (currentItem.GetType() == topItem.GetType())
                            {
                                Item item = arr[random.Next(0, arr.Length)];

                                while (currentItem.GetType() == item.GetType())
                                    item = arr[random.Next(0, arr.Length)];

                                field.GameField[i, j].Item = item;
                            }
                        }

                        else if (leftItem.GetType() == rightItem.GetType() && topItem.GetType() == bottomItem.GetType())
                        {
                            if (currentItem.GetType() == topItem.GetType() || currentItem.GetType() == rightItem.GetType())
                            {
                                Item item = arr[random.Next(0, arr.Length)];
                                int countTry = arr.Length;
                                for (int c = 0; c < arr.Length; c++)
                                {
                                    item = arr[random.Next(0, countTry)];
                                    if (topItem.GetType() != item.GetType() && leftItem.GetType() != item.GetType())
                                    {
                                        field.GameField[i, j].Item = item;
                                        break;
                                    }
                                    countTry -= 1;
                                }
                                field.GameField[i, j].Item = arr[random.Next(0, arr.Length)];

                            }

                            else if (currentItem.GetType() == topItem.GetType() && currentItem.GetType() == rightItem.GetType())
                            {
                                Item item = arr[random.Next(0, arr.Length)];
                                while (currentItem.GetType() == item.GetType())
                                    item = arr[random.Next(0, arr.Length)];
                            }
                        }
                    }

                    //if (j - 1 >= 0 && j + 1 < field.GameField.GetLength(1) && i == 0)
                    //{
                    //    if ((field.GameField[i, j - 1].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //    {
                    //        Item item = arr[random.Next(0, arr.Length)];

                    //        while ((field.GameField[i, j - 1].Item.GetType() == item.GetType()) && (item.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //            item = arr[random.Next(0, arr.Length)];

                    //        field.GameField[i, j].Item = item;
                    //    }
                    //}





























                    //if (j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
                    //{
                    //    if ((field.GameField[i, j - 1].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //    {
                    //        Item item = arr[random.Next(0, arr.Length)];

                    //        while ((field.GameField[i, j - 1].Item.GetType() == item.GetType()) && (item.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //            item = arr[random.Next(0, arr.Length)];

                    //        field.GameField[i, j].Item = item;
                    //    }
                    //}


                    //List<Item> arr = new List<Item> { /*cube, pentagon,*/ rhomb, triangle };

                    //currentItem = field.GameField[i, j].Item;

                    //if (i - 1 >= 0 && i + 1 < field.GameField.GetLength(0) && j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
                    //{
                    //    if ((field.GameField[i - 1, j].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i + 1, j].Item.GetType()) &&
                    //        (field.GameField[i, j - 1].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //    {
                    //        Item item = arr[random.Next(0, arr.Count + 1)];

                    //        field.GameField[i, j].Item = item;
                    //    }
                    //}

                    //if (j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
                    //{
                    //    if ((field.GameField[i, j - 1].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //    {
                    //        Item item = arr[random.Next(0, arr.Length)];

                    //        while ((field.GameField[i, j - 1].Item.GetType() == item.GetType()) && (item.GetType() == field.GameField[i, j + 1].Item.GetType()))
                    //            item = arr[random.Next(0, arr.Length)];

                    //        field.GameField[i, j].Item = item;
                    //    }
                    //}

                    //if (i - 1 >= 0 && i + 1 < field.GameField.GetLength(0))
                    //{
                    //    if ((field.GameField[i - 1, j].Item.GetType() == currentItem.GetType()) && (currentItem.GetType() == field.GameField[i + 1, j].Item.GetType()))
                    //    {
                    //        Item item = arr[random.Next(0, arr.Length)];

                    //        while ((field.GameField[i - 1, j].Item.GetType() == item.GetType()) && (item.GetType() == field.GameField[i + 1, j].Item.GetType()))
                    //            item = arr[random.Next(0, arr.Length)];

                    //        field.GameField[i, j].Item = item;
                    //    }
                    //}

                    //if (i - 1 >= 0 && i + 1 < field.GameField.GetLength(0) && j - 1 >= 0 && j + 1 < field.GameField.GetLength(1))
                    //{
                    //    int count = 0;

                    //    for (int k = 0; k < count; k++)
                    //    {

                    //    }
                    //}

                    field.GameField[i, j].Item.Draw();
                }
            }

            //for (int i = 0; i < field.GameField.GetLength(0); i++)
            //{
            //    for (int j = 0; j < field.GameField.GetLength(1); j++)
            //    {
            //        //Cube cube = new Cube(field.GameField[i, j]);
            //        //Pentagon pentagon = new Pentagon(field.GameField[i, j]);
            //        Rhomb rhomb = new Rhomb(field.GameField[i, j]);
            //        Triangle triangle = new Triangle(field.GameField[i, j]);

            //        Item[] arr = { /*cube, pentagon,*/ rhomb, triangle };

            //        currentItem = field.GameField[i, j].Item;

            //        if (j != 0)
            //        {
            //            prevItem = field.GameField[i, j - 1].Item;

            //            if (prevItem.GetType() == currentItem.GetType())
            //                controller.HorizontalSameItemCount += 1;
            //            else
            //                controller.HorizontalSameItemCount = 1;
            //        }

            //        if (j == 0)
            //            controller.HorizontalSameItemCount = 1;

            //        if (controller.HorizontalSameItemCount == 3)
            //        {
            //            Item item = arr[random.Next(0, arr.Length)];
            //            while (item.GetType() == currentItem.GetType())
            //                item = arr[random.Next(0, arr.Length)];

            //            field.GameField[i, j].Item = item;
            //            controller.HorizontalSameItemCount = 1;
            //        }
            //    }
            //}

            //for (int i = 0; i < field.GameField.GetLength(0); i++)
            //{
            //    for (int j = 0; j < field.GameField.GetLength(1) - 2; j++)
            //    {
            //        //Cube cube = new Cube(field.GameField[i, j]);
            //        //Pentagon pentagon = new Pentagon(field.GameField[i, j]);
            //        Rhomb rhomb = new Rhomb(field.GameField[i, j]);
            //        Triangle triangle = new Triangle(field.GameField[i, j]);

            //        Item[] arr = { /*cube, pentagon,*/ rhomb, triangle };

            //        currentItem = field.GameField[i, j].Item;

            //        if (i + 2 < field.GameField.GetLength(0))
            //        {
            //            nextItem = field.GameField[i + 1, j].Item;
            //            Item nextNextItem = field.GameField[i + 2, j].Item;
            //            if (nextItem.GetType() == currentItem.GetType() && nextItem.GetType() == nextNextItem.GetType())
            //                controller.VerticalSameItemCount = 3;
            //            else
            //                controller.VerticalSameItemCount = 1;
            //        }

            //        if (controller.VerticalSameItemCount == 3)
            //        {
            //            Item item = arr[random.Next(0, arr.Length)];
            //            if (i - 1 < 0)
            //            {
            //                while (item.GetType() == currentItem.GetType() && field.GameField[i, j].Item.GetType)
            //                    item = arr[random.Next(0, arr.Length)];
            //            }
            //            while (item.GetType() == currentItem.GetType() && field.GameField[i, j].Item.GetType)
            //                item = arr[random.Next(0, arr.Length)];

            //            field.GameField[i, j].Item = item;
            //            controller.VerticalSameItemCount = 1;
            //        }
            //        field.GameField[i, j].Item.Draw();
            //    }
            //}


            for (int i = 0; i < field.GameField.GetLength(0); i++)
            {
                for (int j = 0; j < field.GameField.GetLength(1); j++)
                {
                    field.GameField[i, j].Item.Draw();
                }
            }

            //Cell cell = new Cell(new Rect(new Point(5, 5), new Size(11, 7)), null);
            //Cell cell2 = new Cell(new Rect(new Point(25, 5), new Size(11, 7)), null);
            //Cell cell3 = new Cell(new Rect(new Point(45, 5), new Size(11, 7)), null);
            //Cell cell4 = new Cell(new Rect(new Point(65, 5), new Size(11, 7)), null);
            //Cell cell5 = new Cell(new Rect(new Point(85, 5), new Size(11, 7)), null);

            //Cube cube = new Cube(cell, ConsoleColor.Red, 5);
            //Triangle triangle = new Triangle(cell2, ConsoleColor.Blue, 5);
            //Rhomb rhomb = new Rhomb(cell3, ConsoleColor.Yellow, 5);
            //Ellipse ellipse = new Ellipse(cell4);
            //Pentagon pentagon = new Pentagon(cell5);

            //cell.Draw();
            //cell2.Draw();
            //cell3.Draw();
            //cell4.Draw();
            //cell5.Draw();

            //cube.Draw();
            //triangle.Draw();
            //rhomb.Draw();
            //ellipse.Draw();
            //pentagon.Draw();

            //Button button = new Button("Play", new Point(10, 10), new Size(50, 10), '|', '-', 'a');
            //button.Draw();

            //Field field = new Field(new Cell[1][1]);
            //field.Draw();

            Console.SetCursorPosition(0, 55);
        }
    }
}