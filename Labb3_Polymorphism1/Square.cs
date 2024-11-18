namespace Labb3_Polymorphism1;

public class Square : Geometry
{
    public double Side { get; set; }
    
    public Square(double sideLength)
    {
        Side = 8; // Fast värde
    }
    // override av area för att beräkna arean av en kvadrat
    public override double Area()
    {
        return Side * Side;
    }
    // Override ToString för att ge en beskrivning av kvadraten
    public override string ToString()
    {
        return $"Fyrkant med sidlängd {Side}, Area: {Area()}";
    }
}