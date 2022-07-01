namespace DniKata;

public class DniKata
{
    public DniKata(string dniValue)
    {
        if (string.IsNullOrEmpty(dniValue))
            throw new ArgumentException("dniValue should contains value");
    }
}
