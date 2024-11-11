namespace Labb3_Polymorphism1;

class Program
{
    static void Main(string[] args)
    {
        // skapar upp objekten för cirkel, kvadrat och rektangel
        Geometry cicle = new Circle(5);
        Geometry square = new Square(5);
        Geometry rectangle = new Rectangle(5, 10);

        // lägger till mina objekt i en lista för att kunna loopa igenom varje objekt
        List<Geometry> myGeometry = new List<Geometry> { cicle, square, rectangle };

        // loopar igenom min lista och skriver ut arean för varje objekt
        foreach (var geometry in myGeometry)
        {
            // använder inbyggda metoden GetType().Name för att få ut namnet på klassen
            Console.WriteLine($"Arean av {geometry.GetType().Name} är: {geometry.Area()} cm");
        }
    }
}