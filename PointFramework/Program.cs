

namespace NewPointFramework
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            

            LinkedList2 points = new LinkedList2();
            //Line myLine = new(5,6,8,12);
            //myLine.Draw();


            //Rectangle myRect = new(1, 1, 5, 5);
            //myRect.Draw();

            bool quit;
            do
            {
                quit = AddPoint(points);
            } while (quit != true) ;

            Polygon myPoly = new Polygon(points);

            static bool AddPoint(LinkedList2 points)
            {
                int x = 0;
                int y = 0;
                bool xsuccess = false ;
                bool ysuccess = false;
                string[] pointxy;

                while (true)
                {
                    Console.Clear();

                    if (points is not null)
                    {
                        for (int i = 0; i < points.Count; i++)
                        {
                            Point point1 = (Point)points.Get(i);
                            Console.Write($"({point1}) ");
                        }
                    }

                    Console.WriteLine("\nPlease enter point's x and y, seperated by a comma. As in: x,y ");
                    Console.WriteLine("Enter 'z' when finished entering points.");
                    string point = Console.ReadLine();

                    try
                    {
                        pointxy = point.Split(",");
                        string xString = pointxy[0];
                        string yString = pointxy[1];
                        xString = xString.Trim();
                        yString = yString.Trim();

                        xsuccess = int.TryParse(xString, out x);
                        ysuccess = int.TryParse(yString, out y);
                    }
                    catch
                    {
                        if (point != "z")
                        {
                            Console.WriteLine("Error entering points. Try again.");
                        }
                    }

                    if (xsuccess && ysuccess)
                    {
                        Console.Beep();
                        break;
                    }
                    else if (point == "z")
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error entering points. Try again.");
                    }
                }

                Point newPoint = new Point(x, y);
                points.Add(newPoint);
                return false;
            }

            Console.Clear();

            if (points is not null)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Point point1 = (Point)points.Get(i);
                    Console.Write($"({point1}) ");
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Close this polygon? (y,n) : ");
            string close = Console.ReadLine();
            if (close == "y")
            {
                myPoly.Closed = true;
            }
            else { }

            Console.WriteLine("");

            //Polygon myPoly = new Polygon(new Point(5,1), new Point(5,12),new Point(12, 12), new Point(5, 1));
            //Polygon myPoly2 = new Polygon(new Point(5,20), new Point(20,20),new Point(10,15), new Point(20,10), new Point(5,10), new Point(5, 20));
            myPoly.Draw();

 




            Console.ReadLine();

        }//end main
    }//end class
}//end namespace 