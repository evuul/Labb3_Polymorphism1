namespace Labb3_Polymorphism1;

public class Rectangle : Geometry
{
    public double Height { get; set; }
    public double Base { get; set; }
    
    public Rectangle(double height, double width)
    {
        Height = 4; // fasta värden
        Base = 9; // fasta värden
    }
    // override av area för att beräkna arena av en rektangel
    public override double Area()
    {
        return Height * Base;
    }
    public override string ToString()
    {
        return $"Rektangel med höjd {Height} och bas {Base}, Area: {Area()}";
    }
}