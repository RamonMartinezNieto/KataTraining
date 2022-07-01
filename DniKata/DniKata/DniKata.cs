namespace DniKata;

public class DniKata
{
    private const int MAX_LENGTH_DNI = 9;

    public DniKata(string dniValue)
    {
        CheckIfThereIsValue(dniValue);

        CheckCorrectLength(dniValue);
    }
    private static void CheckIfThereIsValue(string dniValue)
    {
        if (string.IsNullOrEmpty(dniValue))
            throw new ArgumentException("dniValue should contains value");
    }

    private static void CheckCorrectLength(string dniValue)
    {
        if (dniValue.Length > MAX_LENGTH_DNI)
            throw new ArgumentException("Length of dniValue is more than nine");
    }


}
