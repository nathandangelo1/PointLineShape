using System.ComponentModel;

public class Polygon
{
    private bool _closed;
    public bool Closed
    {
        get
        {
            return _closed;
        }
        set
        {
            _closed = value;
        }
    }


    public LinkedList2 Points;

    public Polygon(params Point[] pointsArray)
    {
        Points = new LinkedList2();

        for (int i = 0; i < pointsArray.Length; i++)
        {
            Points.Add(pointsArray[i]);
        }
    }
    public Polygon(LinkedList2 points)
    {
        Points = points;
    }
    public void Add(Point point)
    {
        Points.Add(point);
    }
    public void Remove(Point point)
    {
        int index = Points.IndexOf(point);
        Points.Remove(index);
    }
    public void RemoveLast()
    {
        Points.RemoveLast();
    }

    public void Draw()
    {

        if (Points.Count == 1)
        {
            Point point = (Point)Points.Get(0);
            point.Draw();
        }
        else if (Points.Count == 2)
        {
            Line line = new Line((Point)Points.Get(0), (Point)Points.Get(1));
            line.Draw();
        }
        else
        {
            
            for (int i = 0; i < Points.Count - 1; i++)
            {
                Line lineN = new Line((Point)Points.Get(i), (Point)Points.Get(i + 1));
                lineN.Draw();
            }
        }

        if (Closed)
        {
            Line lineN = new Line((Point)Points.GetFirst(), (Point)Points.GetLast());
            lineN.Draw();
        }
        
    }
}
