namespace DniKata.Test.Unit;

public class TestDni
{
    //[Fact]
    //public void Should_Create_DniKata()
    //{
    //    var dni = new DniKata("31970165G"); //happy path
    //}
    
    [Fact]
    public void ShouldThrowArgumentException_IfString_IsEmptyOrNull()
    {
        Action actEmpty = () => new DniKata(string.Empty);
        Action actNull = () => new DniKata(null);
        
        actEmpty.Should()
            .Throw<ArgumentException>()
            .WithMessage("dniValue should contains value");

        actNull.Should()
            .Throw<ArgumentException>()
            .WithMessage("dniValue should contains value");
    }
}