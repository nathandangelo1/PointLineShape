


class Rectangle
{
    private Point _p0;
    private Point _p1;
    private Point _p2;
    private Point _p3;
    
    private int _area;
    private int _width;
    private int _length;

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
            _p1= value;
        } 
    }
    public Point P2
    {
        get
        {
            return _p2;
        }
        set
        {
            _p2 = value;
        }
    }
    public Point P3
    {
        get
        {
            return _p3;
        }
        set
        {
            _p3 = value;
            
        }
    }
    public int Area 
    { 
        get 
        { 
            return Length * Width; 
        } 
    }
    public int Width 
        { 
        get 
        { 
            return _width; 
        } 
        set 
        { 
            _width = value; 
        } 
    }
    public int Length 
    { 
        get 
        { 
            return _length; 
        } 
        set 
        { 
            _length = value; 
        } 
    }
    
    //private static Line[] Lines = new Line[] { new Line(P0, P1), new Line(P1,P2), new Line(P2,P3), new Line(P0,P3) };
    private Line[] Lines = new Line[4];
    public Rectangle(int x, int y, int width, int length)
    {
        P0 = new Point(x, y);

        P1 = new Point(x + width, y);

        P2 = new Point(x, y + length);

        P3 = new Point(x + width, y + length);

        Lines[0] = new Line(P0, P1);
        Lines[1] = new Line(P1.X,P1.Y-1,P3.X,P3.Y-1);
        Lines[2] = new Line(P0.X+1,P1.Y-1,P2.X+1,P2.Y-1);
        Lines[3] = new Line(P2.X , P2.Y-1, P3.X - 1, P3.Y-1);

    }
    //public Rectangle(Point p0, int length, int width)
    //{
    //    P0 = p0;
    //    P1 = new Point(P0.X + width, P0.Y);
    //    P2 = new Point(P0.X + width, P0.Y + length);
    //    P3 = new Point(P0.X, P0.Y + length);

    //    Lines[0] = new Line(P0, P1);
    //    Lines[1] = new Line(P1, P2);
    //    Lines[2] = new Line(P2, P3);
    //    Lines[3] = new Line(P3, P0);
    //}
    //public Rectangle(Point p0, Point p1, Point p2, Point p3)
    //{
    //    P0 = p0;
    //    P1 = p1;
    //    P2 = p2;
    //    P3 = p3;

    //    Lines[0] = new Line(P0, P1);
    //    Lines[1] = new Line(P1, P2);
    //    Lines[2] = new Line(P2, P3);
    //    Lines[3] = new Line(P3, P0);
    //}
    //public Rectangle(int x1, int y1, int x2 , int y2, int x3, int y3, int x4, int y4)
    //{
    //    P0 = new Point(x1,y1);
    //    P1 = new Point(x2, y2);
    //    P2 = new Point(x3, y3);
    //    P3 = new Point(x4, y4);

    //    Lines[0] = new Line(P0, P1);
    //    Lines[1] = new Line(P1, P2);
    //    Lines[2] = new Line(P3, P2);
    //    Lines[3] = new Line(P3, P0);
    //}

    public void Draw()
    {
        //Point corner = new Point(Lines[0].P0.X, Lines[0].P0.Y);
        //corner.SetColor(255, 0, 0);
        //corner.Draw();

        for (int i = 0; i < Lines.Length; i++)
        {
            Lines[i].Draw();
        }
    }

    public void Move(int newX, int newY)
    {
        P0 = new Point(newX, newY);

    }
}
