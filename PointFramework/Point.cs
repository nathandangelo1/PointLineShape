using System.Drawing;

class Point
{
    //CLASS VARIABLES (FIELDS)
    private int _x;
    private int _y;
    private Hue _color;

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
    public Hue Color
    {
        get { return _color; }
        set { _color = value; }
    }//end property

    //CONSTRUCTOR
    public Point(int initialX, int initialY)
    {
        _color = new Hue();
        _x = initialX;
        _y = initialY;
    }//end constructor

    // PUBLIC METHODS
    public void Draw()
    {
        Console.SetCursorPosition(_x, _y);
        SetMyColor();
        Console.Write("*");
        Console.ResetColor();
    }//end method

    public void SetColor(byte red, byte grn, byte blu)
    {
        Color.R = red;
        Color.G = grn;
        Color.B = blu;
    }//end method

    public void SetMyColor()
    {
        //Console.Write("\x1b[48;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
        Console.Write("\x1b[38;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
    }//end method
}//end class