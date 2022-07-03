namespace DniKata.Test.Unit;

internal class Dni
{
    private const int MAX_DNI_LENGTH = 9;

    public Dni(string dniValue)
    {
        if (!dniValue.Length.Equals(MAX_DNI_LENGTH))
            throw new ArgumentException("Lenght should be nine.");
    }
}