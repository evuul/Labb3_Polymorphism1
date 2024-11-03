namespace Labb3_Polymorphism1;

public class Rectangle : Geometry
{
    public double Height { get; set; }
    public double Width { get; set; }
    
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    // override av area för att beräkna arena av en rektangel
    public override double Area()
    {
        return Height * Width;
    }
}