
using System.Numerics;

class Line
{
    private Point   _p0;
    private Point   _p1;
    private double  _slope;
    private double  _midpoint;

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
            if (P1.X - P0.X == 0 || P1.Y - P0.Y == 0) return 0;

            _slope = (P1.Y - P0.Y) / (P1.X - P0.X);
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
    public void Draw()
    {
        Point nP0 = new(P0.X,P0.Y);
        double steps;
        double dx = P1.X - P0.X;
        double dy = P1.Y - P0.Y;
        //double m = dy / dx;

        if (Math.Abs(dx) > Math.Abs(dy))
        {
            steps = Math.Abs(dx);
        }
        else
        {
            steps = Math.Abs(dy);
        }

        for (int i = 0; i < steps; i++)
        {
            if (Slope == 0)
            {
                if(dy == 0) 
                {
                    nP0.X = (int)double.Round(1 + nP0.X);
                    nP0.SetColor(255, 0, 0);
                    nP0.Draw();
                }
                else
                {
                    nP0.Y = (int)double.Round(1 + nP0.Y);
                    nP0.SetColor(255, 0, 0);
                    nP0.Draw();
                }

            }
            else if (Slope < 1)
            {
                nP0.X = (int)double.Round(1 + nP0.X);
                nP0.Y = (int)double.Round(Slope + nP0.Y);
                nP0.SetColor(255, 0, 0);
                nP0.Draw();
            }
            else if (Slope == 1)
            {
                nP0.X = (int)double.Round(1 + nP0.X);
                nP0.Y = (int)double.Round(1 + nP0.Y);
                nP0.SetColor(255, 0, 0);
                nP0.Draw();
            }
            else if ( Slope > 1)
            {
                nP0.X = (int)double.Round((1 / Slope) + P0.X);
                nP0.Y = (int)double.Round(1 + P0.Y);
                nP0.SetColor(255, 0, 0);
                nP0.Draw();
            }
        }
    }
}

