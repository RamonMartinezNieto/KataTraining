using System.Linq;

namespace DniKata;

public class Dni
{
    private const int MAX_DNI_LENGTH = 9;
    private static readonly char[] EXCLUDE_LAST_CHARS = { 'I', 'O', 'U', 'Ñ' };
    private static readonly char[] VALIDS_FIRST_CHARS = { 'X', 'Y', 'Z' };

    public Dni(string dniValue)
    {
        CheckCorrectLength(dniValue);
        CheckIfLastCharacterIsLetter(dniValue);
        CheckLastCharacter(dniValue);
        CheckIfCorrectFirstCharacter(dniValue);
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

    private static void CheckLastCharacter(string dniValue)
    {
        foreach (char excludeChar in EXCLUDE_LAST_CHARS)
        {
            if (dniValue[^1].Equals(excludeChar))
                throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
        }
    }

    private static void CheckIfCorrectFirstCharacter(string dniValue)
    {
        if (char.IsLetter(dniValue[0]) && !VALIDS_FIRST_CHARS.Contains(dniValue[0]))
            throw new ArgumentException("The first character cannot be a character except X, Y or Z.");
    }
}