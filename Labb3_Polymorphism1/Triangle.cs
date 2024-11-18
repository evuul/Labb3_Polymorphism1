namespace Labb3_Polymorphism1;

public class Triangle : Geometry
{
    public double Base { get; set; }
    public double Height { get; set; }
    
    public Triangle() 
    {
        Base = 2; // fasta värden
        Height = 4; // fasta värden
    }
    // override av area för att beräkna arean av en triangel
    public override double Area()
    {
        return Base * Height / 2;
    }
    // Override ToString för att ge en beskrivning av triangeln
    public override string ToString()
    {
        return $"Triangel med basen: {Base} och höjden: {Height}, Area: {Area()}";
    }
}