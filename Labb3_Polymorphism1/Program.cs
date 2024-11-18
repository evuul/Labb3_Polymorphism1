namespace Labb3_Polymorphism1;

class Program
{
    static void Main(string[] args)
    {
        // skapar upp objekten för cirkel, kvadrat och rektangel
        Geometry circle = new Circle();
        Geometry square = new Square();
        Geometry rectangle = new Rectangle();
        Geometry triangle = new Triangle();

        // lägger till mina objekt i en lista för att kunna loopa igenom varje objekt
        var myGeometry = new List<Geometry> { circle, square, rectangle, triangle };

        // loopar igenom min lista och skriver ut presentation av varje objekt med hjälp av ToString()
        foreach (var geometry in myGeometry)
        {
            Console.WriteLine(geometry.ToString());
        }
    }
}