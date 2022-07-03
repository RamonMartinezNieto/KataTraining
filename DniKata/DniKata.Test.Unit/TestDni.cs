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

    [Fact]
    public void LastCharacter_CannotBe_U() 
    {
        Action act = () => new Dni("34272318U"); //sad path

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The last character cannot be U, I, O, or Ñ.");
    }

    [Fact]
    public void LastCharacter_CannotBe_I() 
    {
        Action act = () => new Dni("34272318I"); //sad path

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The last character cannot be U, I, O, or Ñ.");
    }

    [Fact]
    public void LastCharacter_CannotBe_O() 
    {
        Action act = () => new Dni("34272318O"); //sad path

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The last character cannot be U, I, O, or Ñ.");
    }

    [Fact]
    public void LastCharacter_CannotBe_Eje_NWithTilde() 
    {
        Action act = () => new Dni("34272318Ñ"); //sad path

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("The last character cannot be U, I, O, or Ñ.");
    }
}
