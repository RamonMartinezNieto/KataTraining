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
        CheckLastCharacterIfItIsValid(dniValue);
        CheckIntCharsInDni(dniValue);
        CheckIfCorrectFirstCharacter(dniValue);

        CheckIfValidLastLetter(dniValue);
    }

    private static void CheckIfValidLastLetter(string dniValue)
    {
        if (!IsFirstCharacterALetter(dniValue))
        {
            int tempDniValue = Convert.ToInt32(dniValue[0..7]);

            if (tempDniValue % 23 == 0 && !dniValue[^1].Equals('T'))
            {
                throw new ArgumentException("Invalid letter.");
            }

            if (tempDniValue % 23 == 1 && !dniValue[^1].Equals('R'))
            {
                throw new ArgumentException("Invalid letter.");
            }

            if (tempDniValue % 23 == 1 && !dniValue[^1].Equals('W'))
            {
                throw new ArgumentException("Invalid letter.");
            }
        }
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

    private static void CheckLastCharacterIfItIsValid(string dniValue)
    {
        if (EXCLUDE_LAST_CHARS.Contains(dniValue[^1])) 
            throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
    }

    private static bool IsFirstCharacterALetter(string dniValue) 
        => char.IsLetter(dniValue[0]);

    private static bool IsFirstLetterCorrect(string dniValue) 
        => VALIDS_FIRST_CHARS.Contains(dniValue[0]);

    private static void CheckIfCorrectFirstCharacter(string dniValue)
    {
        if (IsFirstCharacterALetter(dniValue) && !IsFirstLetterCorrect(dniValue)) 
            throw new ArgumentException("The first character cannot be a character except X, Y or Z.");
    }

    private static void CheckIntCharsInDni(string dniValue)
    {
        for (int i = 1; i < MAX_DNI_LENGTH - 1; i++)
        {
            if (char.IsLetter(dniValue[i]))
                throw new ArgumentException("First 8 character should be int, first one can be X, Y, Z for NIE.");
        }
    }

}