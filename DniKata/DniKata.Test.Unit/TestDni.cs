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
    [InlineData("X0098688H")] //happy path
    [InlineData("Y9661016H")] //happy path
    [InlineData("Z5090857L")] //happy path
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

    [Theory]
    [InlineData("X0000000R")]
    [InlineData("Y0000000P")]
    [InlineData("Z0000000P")]
    public void WhenFirstLetterIsXYZ_ItConvertTo012_And_IFModOf23IntPartIs012_ShouldThrowExceptionIfTheLetterIsNot_TRW(string value)
    {
        Action act = () => new Dni(value);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage("Invalid letter.");
    }

    //All are happy path
    [Theory]
    [InlineData("31970165G")]
    [InlineData("10448738E")]
    [InlineData("68163822X")]
    [InlineData("68132163E")]
    [InlineData("50791233B")]
    [InlineData("90250990W")]
    [InlineData("87477013D")]
    [InlineData("34272318H")]
    [InlineData("54956042A")]
    [InlineData("78176129A")]
    [InlineData("49390008S")]
    [InlineData("90583399S")]
    public void ShouldNotThrwoAnyException_WhenDNIIsCorrect(string value) 
    {
        //note, in C# if any exception throw the test fail
        new Dni(value);
    }    
    
    //All are happy path
    [Theory]
    [InlineData("Z5090857L")]
    [InlineData("Y9661016H")]
    [InlineData("Y1019582Y")]
    [InlineData("Y2517413P")]
    [InlineData("Z5470399S")]
    [InlineData("Y0468622B")]
    [InlineData("X4326926M")]
    [InlineData("Z6552219F")]
    public void ShouldNotThrwoAnyException_WhenNIEIsCorrect(string value) 
    {
        //note, in C# if any exception throw the test fail
        new Dni(value);
    }
}
