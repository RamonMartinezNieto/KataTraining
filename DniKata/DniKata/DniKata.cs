namespace DniKata;

public class DniKata
{
    private const int MAX_LENGTH_DNI = 9;

    public DniKata(string dniValue)
    {
        if (string.IsNullOrEmpty(dniValue))
            throw new ArgumentException("dniValue should contains value");

        if(dniValue.Length > MAX_LENGTH_DNI)
            throw new ArgumentException("Length of dniValue is more than nine");
    }
}
