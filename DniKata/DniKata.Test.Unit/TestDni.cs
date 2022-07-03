namespace DniKata.Test.Unit;

// DNI "documento nacional de identidad"  'identity national document' (in spain) 
// NIE: "numero de identidad de extranjero" 'foreign identity number' (in spain)
//
// Rules:
// Length 9
// First 8 characters are numbers 
// Last one is a char 
// Last one is a control character, excluded U I O Ñ
// Exception NIE: first character is X Y Z 
// X = 0, Y = 1, Z = 2

//SadPath: 00000001K  | 00000002L
//HappyPath: 34272318H  |  Z5090857L

public class TestDni
{

    [Theory]
    [InlineData("342723180H")]
    [InlineData("3427231H")]
    public void Lenght_ShouldBe_Nine(string value) 
    {
        Action act = () => new Dni(value);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Lenght should be nine.");
    }

    [Fact]
    public void LastCharacter_ShoulBe_Character() 
    {
        Action act = () => new Dni("342723180"); //sad path

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Last character should be a character.");
    }

    [Theory]
    [InlineData("34272318U")]//sad path
    [InlineData("34272318I")]//sad path
    [InlineData("34272318O")]//sad path
    [InlineData("34272318Ñ")]//sad path
    public void LastCharacter_CannotBe_U_I_O_NWithTilde(string value) 
    {
        Action act = () => new Dni(value); 

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The last character cannot be U, I, O, or Ñ.");
    }
    
    [Fact]
    public void FirstCharacter_CannotBe_Character_ExceptXYZ()
    {
        Action act = () => new Dni("S1404966B"); 

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The first character cannot be a character except X, Y or Z.");
    }    

    [Theory]
    [InlineData("X1404966B")]
    [InlineData("Y1404966B")]
    [InlineData("Z1404966B")]
    public void FirstCharacter_CanBe_XYZ(string value)
    {
        // no exception, test pass if there isn't a exception  and fail with an exceptioin
        Dni dni = new (value); 
    }

    [Fact]
    public void Second_Char_Should_Be_Int() 
    {
        Action act = () => new Dni("3Z272318H");

        act.Should()
           .Throw<ArgumentException>()
           .WithMessage("First 8 character should be int, first one can be X, Y, Z for NIE.");
    }

    [Fact]
    public void Third_Char_Should_Be_Int() 
    {
        Action act = () => new Dni("31R72318H");

        act.Should()
           .Throw<ArgumentException>()
           .WithMessage("First 8 character should be int, first one can be X, Y, Z for NIE.");
    }
}
