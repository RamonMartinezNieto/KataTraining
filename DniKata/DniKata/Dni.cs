using System.Collections.Generic;
using System.Linq;

namespace DniKata;

public class Dni
{
    private const int MAX_DNI_LENGTH = 9;
    private static readonly char[] EXCLUDE_LAST_CHARS = { 'I', 'O', 'U', 'Ñ' };
    private static readonly char[] VALIDS_FIRST_CHARS = { 'X', 'Y', 'Z' };

    private static Dictionary<int, char> LETTERS_RULES = new()
    {
        {0,'T'},
        {1,'R'},
        {2,'W'},
        {3,'A'},
        {4,'G'},
        {5,'M'},
        {6,'Y'},
        {7,'F'},
        {8,'P'},
        {9,'D'},
        {10,'X'},
        {11,'B'},
        {12,'N'},
        {13,'J'},
        {14,'Z'},
        {15,'S'},
        {16,'Q'},
        {17,'V'},
        {18,'H'},
        {19,'L'},
        {20,'C'},
        {21,'K'},
        {22,'E'},
    }; 
    
    private static Dictionary<int, char> FIRST_LETTERS_RULES = new()
    {
        {0,'X'},
        {1,'Y'},
        {2,'Z'}
    };

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
        int tempDniValue = 0;

        if (IsFirstCharacterALetter(dniValue))
        {
            foreach (var item in FIRST_LETTERS_RULES)
            {
                if (dniValue[0].Equals(item.Value))
                {
                    tempDniValue = Convert.ToInt32(dniValue[1..8]) + item.Key;
                }
            }
        }
        else 
        {
            tempDniValue = Convert.ToInt32(dniValue[0..8]);
        }

        foreach (var item in LETTERS_RULES) 
        {
            if (tempDniValue % 23 == item.Key && !dniValue[^1].Equals(item.Value))
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