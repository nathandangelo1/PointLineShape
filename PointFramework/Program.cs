namespace NewPointFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[20];
            //Random rand = new Random();



            ////CREATE RANDOM POINTS AND STORE THEM TO THE ARRAY
            //for (int storeIndex = 0; storeIndex < points.Length; storeIndex++)
            //{
            //    Point currentPoint = new Point(rand.Next(0, 16), rand.Next(0, 16));
            //    currentPoint.SetColor(255, 128, 000);

            //    currentPoint.Color = new Hue(0, 0, 0);

            //    points[storeIndex] = currentPoint;
            //}//end for


            ////DRAW RANDOM POINTS IN THE ARRAY
            //for (int drawIndex = 0; drawIndex < points.Length; drawIndex++)
            //{
            //    Point currentPoint = points[drawIndex];
            //    currentPoint.Draw();


            //Line myLine = new Line(5, 5, 25, 25);

            Rectangle myRect = new Rectangle(0, 0, 10, 10);
            myRect.Draw();
            
            Console.ReadLine();

            //}//end for

        }//end main
    }//end class
}//end namespace 