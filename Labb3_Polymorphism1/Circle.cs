namespace Labb3_Polymorphism;

public class Circle : Geometry
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Override av Area() för att beräkna arean för en cirkel
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}