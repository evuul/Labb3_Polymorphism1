// Valde att byta Geometry till en abstrakt klass för att tvinga subklasserna att implementera Area() metoden.
public abstract class Geometry
{
    // Abstrakt metod som subklasserna måste implementera
    // säkerställer att alla subklasser har en Area() metod som uppgiften kräver
    public abstract double Area();
    
    // Abstrakt metod för att retunera en sträng med information om figuren vi presenterar
    public abstract string ToString();

}