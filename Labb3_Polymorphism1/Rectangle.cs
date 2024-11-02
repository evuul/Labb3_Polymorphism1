namespace Labb3_Polymorphism;

public class Rectangle : Geometry
{
    public double height { get; set; }
    public double width { get; set; }
    
    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    // override av area för att beräkna arena av en rektangel
    public override double Area()
    {
        return height * width;
    }
}