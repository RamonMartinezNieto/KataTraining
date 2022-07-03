namespace DniKata.Test.Unit;

internal class Dni
{
    private const int MAX_DNI_LENGTH = 9;
    private static readonly char[] EXCLUDE_LAST_CHARS = { 'I', 'O', 'U', 'Ñ' };

    public Dni(string dniValue)
    {
        CheckCorrectLength(dniValue);
        CheckIfLastCharacterIsLetter(dniValue);
        CheckLastCharacter(dniValue);

        var firstCharacter = dniValue[0];
        if (char.IsLetter(firstCharacter))
        {
            if(!firstCharacter.Equals('X') && !firstCharacter.Equals('Y') && !firstCharacter.Equals('Z')) 
                throw new ArgumentException("The first character cannot be a character except X, Y or Z.");            
            
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

    private static void CheckLastCharacter(string dniValue)
    {
        foreach (char excludeChar in EXCLUDE_LAST_CHARS) 
        {
            if (dniValue[^1].Equals(excludeChar))
                throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
        }
    }
}