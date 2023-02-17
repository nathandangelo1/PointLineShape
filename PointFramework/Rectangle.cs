

using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

class Rectangle
{
    private Point _p0;
    private Point _p1;
    private Point _p2;
    private Point _p3;
    
    private int _area;
    private int _width;
    private int _height;

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
            return Height * Width; 
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
    public int Height 
    { 
        get 
        {
            return _height;
        } 
        set 
        { 
            _height = value; 
        } 
    }
    
    public Line[] Lines = new Line[4];

    public Rectangle(int x, int y, int width, int length)
    {
        _width = width;
        _height = length;
        P0 = new Point(x, y);
        P1 = new Point(x + width, y);
        P2 = new Point(x, y + length);
        P3 = new Point(x + width, y + length);

        MakeRect(P0,P1,P2,P3);
    }

    public Rectangle(Point p0, int length, int width)
    {
        _width = width;
        _height = length;

        P0 = p0;
        P1 = new Point(P0.X + width, P0.Y);
        P2 = new Point(P0.X, P0.Y + length);
        P3 = new Point(P0.X + width, P0.Y + length);

        MakeRect(P0, P1, P2, P3);
    }

    public Rectangle(Point p0, Point p1, Point p2, Point p3)
    {
        _width = p1.X - p0.X;
        _height = p2.Y - p0.Y;

        P0 = p0;
        P1 = p1;
        P2 = p2;
        P3 = p3;

        MakeRect(P0, P1, P2, P3);
    }

    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
    {
        _width = x2 - x1;
        _height = y3 - y1;

        P0 = new Point(x1, y1);
        P1 = new Point(x2, y2);
        P2 = new Point(x3, y3);
        P3 = new Point(x4, y4);

        MakeRect(P0, P1, P2, P3);
    }

    public void MakeRect(Point P0, Point P1, Point P2, Point P3)
    {
        //Lines[0] = new Line(P0, P1);
        //Lines[1] = new Line(P1.X, P1.Y - 1, P3.X, P3.Y - 1);
        //Lines[2] = new Line(P0.X + 1, P1.Y - 1, P2.X + 1, P2.Y - 1);
        //Lines[3] = new Line(P2.X, P2.Y - 1, P3.X - 1, P3.Y - 1);
        Lines[0] = new Line(P0, P1);
        Lines[1] = new Line(P1.X, P1.Y, P3.X, P3.Y);
        Lines[2] = new Line(P0.X, P1.Y, P2.X, P2.Y);
        Lines[3] = new Line(P2.X, P2.Y, P3.X, P3.Y);
    }

    public void Draw()
    {
        foreach (Line line in Lines)
        {
            line.Draw();
        }
    }

    public void Move(int newX, int newY)
    {
        P0 = new Point(newX, newY);
        P1 = new Point(newX + Width, newY);
        P2 = new Point(newX, newY + Height);
        P3 = new Point(newX + Width, newY + Height);

        MakeRect(P0, P1, P2, P3);

    }

    public void Reform(int x1, int y1, int length, int width)
    {
        Height = length;
        Width = width;

        P0 = new Point(x1, y1);
        P1 = new Point(x1 + Width, y1);
        P2 = new Point(x1, y1 + Height);
        P3 = new Point(x1 + Width, y1 + Height);

        MakeRect(P0, P1, P2, P3);
    }

    public void Reform(int x1, int y1, int x2 , int y2, int x3, int y3, int x4, int y4)
    {
        Height = y3 - y1;
        Width = x2 - x1;

        P0 = new Point(x1, y1);
        P1 = new Point(x1 + Width, y1);
        P2 = new Point(x1, y1 + Height);
        P3 = new Point(x1 + Width, y1 + Height);

        MakeRect(P0, P1, P2, P3);
    }
}
