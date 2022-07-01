namespace DniKata;

public class DniKata
{
    public DniKata(string dniValue)
    {
        if (string.IsNullOrEmpty(dniValue))
            throw new ArgumentException("dniValue should contains value");

        if(dniValue.Length > 9)
            throw new ArgumentException("Length of dniValue is more than nine");
    }
}
