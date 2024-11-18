namespace Labb3_Polymorphism1;

public class Circle : Geometry
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = 4; // Fast värde
    }

    // Override av Area() för att beräkna arean för en cirkel
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
    // Override av ToString() för att retunera en sträng med information om cirkeln och F2 för att få ut 2 decimaler
    public override string ToString()
    {
        return $"Cirkel med radie {Radius}, Area: {Area():F2}";
    }
}