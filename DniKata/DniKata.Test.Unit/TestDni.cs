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
    [InlineData("X0000000T")] //happy path
    [InlineData("Y0000000R")] //happy path
    [InlineData("Z0000000W")] //happy path
    public void FirstCharacter_CanBe_XYZ(string value)
    {
        // no exception, test pass if there isn't a exception  and fail with an exceptioin
        Dni dni = new(value);
    }

    [Theory]
    [InlineData("3R272318H")]
    [InlineData("30R72318H")]
    [InlineData("302R2318H")]
    [InlineData("3027R318H")]
    [InlineData("30272R18H")]
    [InlineData("302723R8H")]
    [InlineData("3027231RH")]
    public void Characters_1To7_ShouldBeInt(string value)
    {
        Action act = () => new Dni(value);

        act.Should()
           .Throw<ArgumentException>()
           .WithMessage("First 8 character should be int, first one can be X, Y, Z for NIE.");
    }

    //all sad path to check exception if the las letter is incorrect
    [Theory]
    [InlineData("00000000R")]
    [InlineData("00000001S")]
    [InlineData("00000002S")]
    [InlineData("00000003P")]
    [InlineData("00000004P")]
    [InlineData("00000005P")]
    [InlineData("00000006P")]
    [InlineData("00000007P")]
    [InlineData("00000008Z")]
    [InlineData("00000009R")]
    [InlineData("00000010R")]
    [InlineData("00000011S")]
    [InlineData("00000012S")]
    [InlineData("00000013S")]
    [InlineData("00000014S")]
    [InlineData("00000015T")]
    [InlineData("00000016S")]
    [InlineData("00000017S")]
    [InlineData("00000018S")]
    [InlineData("00000019S")]
    [InlineData("00000020S")]
    [InlineData("00000021S")]
    [InlineData("00000022S")]
    public void WhenModOf23IntPart_Is0_ShouldBeComparedWithTheLetter_T(string value)
    {
        Action act = () => new Dni(value);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Invalid letter.");
    }

    [Fact]
    public void WhenFirstLetterIsX_ItConvertTo0_And_IFModOf23IntPartIs0_ShouldThrowExceptionIfTheLetterIsNot_T()
    {
        Action act = () => new Dni("X0000000R");

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Invalid letter.");
    }

    [Fact]
    public void WhenFirstLetterIsY_ItConvertTo1_And_IFModOf23IntPartIs1_ShouldThrowExceptionIfTheLetterIsNot_R()
    {
        Action act = () => new Dni("Y0000000P");

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Invalid letter.");
    }
    
    [Fact]
    public void WhenFirstLetterIsZ_ItConvertTo2_And_IFModOf23IntPartIs2_ShouldThrowExceptionIfTheLetterIsNot_W()
    {
        Action act = () => new Dni("Y0000000P");

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Invalid letter.");
    }

}
