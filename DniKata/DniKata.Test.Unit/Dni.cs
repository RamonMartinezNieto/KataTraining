namespace DniKata.Test.Unit;

internal class Dni
{
    public Dni(string v)
    {
        if (v.Length > 9)
            throw new ArgumentException("Lenght should be nine.");
    }
}