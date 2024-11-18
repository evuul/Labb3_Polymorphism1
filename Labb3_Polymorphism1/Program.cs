namespace Labb3_Polymorphism1;

class Program
{
    static void Main(string[] args)
    {
        // skapar upp objekten för cirkel, kvadrat och rektangel
        Geometry circle = new Circle(5);
        Geometry square = new Square(5);
        Geometry rectangle = new Rectangle(5, 10);
        Geometry triangle = new Triangle(5, 10);

        // lägger till mina objekt i en lista för att kunna loopa igenom varje objekt
        var myGeometry = new List<Geometry> { circle, square, rectangle, triangle };

        // loopar igenom min lista och skriver ut presentation av varje objekt med hjälp av ToString()
        foreach (var geometry in myGeometry)
        {
            Console.WriteLine(geometry.ToString());
        }
    }
}