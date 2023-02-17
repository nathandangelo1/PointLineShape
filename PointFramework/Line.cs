class Line
{
    private Point   _p0;
    private Point   _p1;
    private double  _slope;
    private double  _midpoint;
    public Point _nextStart;

    public Point NextStart
    {
        get
        {
            return _nextStart;
        }
        set
        {
            _nextStart = value;
        }
    }
    public Point P0
    {
        get
        {
            return _p0;
        }
        set
        {
            _p0 = value;
        }
    }
    public Point P1
    {
        get
        {
            return _p1;
        }
        set
        {
            _p1 = value;
        }
    }
    public double Slope
    {
        get
        {
            //if (P1.X - P0.X == 0 || P1.Y - P0.Y == 0) return 0;

            _slope = (double)(P1.Y - P0.Y) / (P1.X - P0.X);
            return _slope;
        }
    }
    public Point MidpointPoint
    {
        get
        {
            Point midpoint = new(0, 0)
            {
                X = (P0.X + P1.X) / 2,
                Y = (P0.Y + P1.Y) / 2
            };
            return midpoint;
        }
    }
    //public double MidpointReal
    //{
    //    get
    //    {
    //        double x = P1.X - P0.X;
    //        double y = P1.Y - P0.Y;
    //        x = Math.Pow(x, 2);
    //        y = Math.Pow(y, 2);
    //        return Math.Sqrt(x + y);
    //    }
    //}

    public Line(Point p0, Point p1)
    {
        P0 = p0;
        P1 = p1;
    }
    public Line() { }
    public Line(int x1, int y1, int x2, int y2)
    {
        P0 = new Point(x1, y1);
        P1 = new Point(x2, y2);
    }

    public void Perturb(int xmin, int xmax, int ymin, int ymax)
    {
        Random rand = new Random();

        int xPer = rand.Next(xmin, xmax + 1);
        int yPer = rand.Next(ymin, ymax + 1);

        P0 = new Point(P0.X + xPer, P0.Y + yPer);

        int xPer2 = rand.Next(xmin, xmax + 1);
        int yPer2 = rand.Next(ymin, ymax + 1);

        P1 = new Point(P1.X + xPer2, P1.Y + yPer2);

        Line perLine = new Line(P0, P1);
        perLine.Draw();

    }
    //public void Draw()
    //{
    //    Point nP0 = new(P0.X, P0.Y);
    //   // nP0.Draw();

    //    double steps;
    //    double dx = P1.X - P0.X;
    //    double dy = P1.Y - P0.Y;
    //    //double m = dy / dx;
    //    double x = P0.X;
    //    double y = P0.Y;
    //    bool stepsX = false;

    //    if (Math.Abs(dx) > Math.Abs(dy))
    //    {
    //        steps = Math.Abs(dx) ;
    //        stepsX = true;
    //    }
    //    else
    //    {
    //        steps = Math.Abs(dy) ;
    //    }
    //    for (int i = 0; i < steps; i++)
    //    {
    //        if (stepsX)
    //        {
    //            if (P1.Xequals(x-1))
    //            {
    //                break;
    //            }
    //        }
    //        else
    //        {
    //            if (P1.Yequals(y))
    //            {
    //                break;
    //            }
    //        }

    //        if (Slope < 1)
    //        {
    //            if(Slope == double.NegativeInfinity)
    //            {
    //                x = P0.X + 2;
    //                y = (y - 1);
    //            }
    //            else if (Slope == 0 )
    //            {
    //                if (dx < 0)
    //                {
    //                    x = x - 1;
    //                    y = P0.Y;
    //                }
    //                else
    //                {
    //                    x = x + 1;
    //                    y = P0.Y;
    //                }
    //            }
    //            else
    //            {
    //                x = double.Round((1 + x), MidpointRounding.AwayFromZero);
    //                y = double.Round((Slope + y), MidpointRounding.AwayFromZero);
    //            }

    //            //nP0.SetColor(255, 0, 0);
    //            nP0 = new((int)x, (int)y);
    //            nP0.Draw();
    //        }
    //        else if (Slope == 1)
    //        {
    //            x = double.Round((1 + x), MidpointRounding.AwayFromZero);
    //            y = double.Round((1 + y), MidpointRounding.AwayFromZero); 
    //            //nP0.SetColor(255, 0, 0);
    //            nP0 = new((int)x, (int)y);
    //            nP0.Draw();
    //        }
    //        else if (Slope > 1)
    //        {
    //            //if (Slope == double.PositiveInfinity)
    //            //{
    //            //    x = P0.X;
    //            //    y = y + 1;
    //            //}
    //            x = double.Round(((1 / Slope) + x), MidpointRounding.AwayFromZero);
    //            y = double.Round((1 + y), MidpointRounding.AwayFromZero); 
    //            //nP0.SetColor(255, 0, 0);
    //            nP0 = new((int)x, (int)y);
    //            nP0.Draw();
    //        }

    //    }
    //}

    public void Draw()
    {
        // Calculate the difference between the x and y components
        int x1 = P0.X;
        int y1 = P0.Y;
        int x2 = P1.X;
        int y2 = P1.Y;
        int dx = x2 - x1;
        int dy = y2 - y1;
        int steps;

        double xInc;
        double yInc;
        double x = x1;
        double y = y1;

        // Identify the number of steps to put pixels
        if (Math.Abs(dx) > Math.Abs(dy))
        {
            steps = Math.Abs(dx);
        }// End if
        else
        {
            steps = Math.Abs(dy);
        }// End else        

        xInc = (double)dx / steps;
        yInc = (double)dy / steps;

        P0.Draw();

        for (int k = 0; k <= steps - 1; k++)
        {
            //newPoint.SetColor(255, 0, 0);
            Point newPoint = new Point((int)x, (int)y);
            newPoint.Draw();
            x += xInc;
            y += yInc;
        }

        P1.Draw();
    }
}

