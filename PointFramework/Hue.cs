class Hue
{
    //FIELDS
    private byte _red;
    private byte _grn;
    private byte _blu;


    //PROPERTIES

    public byte R
    {
        get
        {
            return _red;
        }//end get

        set
        {
            _red = value;
        }//end set
    }//end property

    public byte G
    {
        get
        {
            return _grn;
        }//end get

        set
        {
            _grn = value;
        }//end set
    }//end property
    public byte B
    {
        get
        {
            return _blu;
        }//end get

        set
        {
            _blu = value;
        }//end set
    }//end property


    //CONSTRUCTORS
    public Hue()
    {
    }//end constructor
    public Hue(byte redLevel, byte grnLevel, byte bluLevel)
    {
        SetHue(redLevel, grnLevel, bluLevel);
    }//end constructor

    //METHODS
    public void SetHue(byte redLevel, byte grnLevel, byte bluLevel)
    {
        _red = redLevel;
        _grn = grnLevel;
        _blu = bluLevel;
    }//end if
}//end class
