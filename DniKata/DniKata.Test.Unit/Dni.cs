namespace DniKata.Test.Unit;

internal class Dni
{
    private const int MAX_DNI_LENGTH = 9;

    public Dni(string dniValue)
    {
        CheckCorrectLength(dniValue);
        CheckIfLastCharacterIsLetter(dniValue);

    }

    private static void CheckCorrectLength(string dniValue)
    {
        if (!dniValue.Length.Equals(MAX_DNI_LENGTH))
            throw new ArgumentException("Lenght should be nine.");
    }
    private static void CheckIfLastCharacterIsLetter(string dniValue)
    {
        if (!char.IsLetter(dniValue[^1]))
            throw new ArgumentException("Last character should be a character.");
    }

}