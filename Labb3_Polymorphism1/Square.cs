namespace Labb3_Polymorphism;

public class Square : Geometry
{
    public double SideLength { get; set; }
    
    public Square(double sideLength)
    {
        SideLength = sideLength;
    }
    // override av area för att beräkna arean av en kvadrat
    public override double Area()
    {
        return SideLength * SideLength;
    }
}