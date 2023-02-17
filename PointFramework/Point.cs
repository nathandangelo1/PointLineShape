

public class Point
{
    //CLASS VARIABLES (FIELDS)
    private int _x;
    private int _y;
    //Hue _color;

    public int X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value ;
        }
    }
    public int Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }

    //PROPERTY
    //Hue Color
    //{
    //    get { return _color; }
    //    set { _color = value; }
    //}//end property

    //CONSTRUCTOR
    public Point(int initialX, int initialY)
    {
        //_color = new Hue();
        _x = initialX;
        _y = initialY;
    }//end constructor

    // PUBLIC METHODS
    //public bool 1equals(int point2)
    //{
    //    int thisY = Y;
    //    int point2Y = point2;
    //    if (thisY == point2Y) return true;
    //    return false;
    //}

    public override string ToString()
    {
        string xpoint = X.ToString();
        string ypoint = Y.ToString();
        string point = $"{xpoint}, {ypoint}";
        return point;
    }
    public bool Yequals(double point2)
    {
        int thisY = Y;
        int point2Y = (int)point2;
        if (thisY == point2Y) return true;
        return false;
    }
    public bool Xequals(double point2)
    {
        int thisX = X;
        int point2X = (int)point2;
        if (thisX == point2X) return true;
        return false;
    }
    public bool IsGreaterX (Point point2)
    {
        if (X > point2.X) return true;
        return false;
    }
    public bool IsLesserX(Point point2)
    {
        if (X < point2.X) return true;
        return false;
    }
    public bool IsGreaterY(Point point2)
    {
        if (Y > point2.Y) return true;
        return false;
    }
    public bool IsLesserY(Point point2)
    {
        if (Y < point2.Y) return true;
        return false;
    }
    public bool Equals(Point point2)
    {
        int x1 = X;
        int y1 = Y;
        int x2 = point2.X;
        int y2 = point2.Y;

        if(x1 == x2 && y1 == y2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Draw()
    {
        Console.SetCursorPosition(_x, _y);
        //SetMyColor();
        Console.Write("*");
        //Console.ResetColor();
    }//end method

    //public void SetColor(byte red, byte grn, byte blu)
    //{
    //    Color.R = red;
    //    Color.G = grn;
    //    Color.B = blu;
    //}//end method

    //public void SetMyColor()
    //{
    //    //Console.Write("\x1b[48;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
    //    Console.Write("\x1b[38;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
    //}//end method
}//end class