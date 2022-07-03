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
    //First tests are to implement the clas
    [Fact]
    public void ShouldCreateDniValueObject() 
    {
        Dni dni = new("34272318H"); //Using happy path to avoid the fail of the test in the future. 
    }

    [Fact]
    public void Lenght_ShouldBe_LessThanTen() 
    {
        Action act = () => new Dni("342723180H"); //wrong DNI 

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Lenght should be nine.");
    }
    
    [Fact]
    public void Lenght_ShouldBe_MoreThanEight() 
    {
        Action act = () => new Dni("3427231H"); //wrong DNI 

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
    
}
