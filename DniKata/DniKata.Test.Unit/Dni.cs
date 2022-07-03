namespace DniKata.Test.Unit;

internal class Dni
{
    private const int MAX_DNI_LENGTH = 9;

    public Dni(string dniValue)
    {
        CheckCorrectLength(dniValue);
        CheckIfLastCharacterIsLetter(dniValue);

        if (dniValue[^1].Equals('U')) 
        {
            throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
        }     
        
        if (dniValue[^1].Equals('I')) 
        {
            throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
        }    
        
        if (dniValue[^1].Equals('O')) 
        {
            throw new ArgumentException("The last character cannot be U, I, O, or Ñ.");
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

}