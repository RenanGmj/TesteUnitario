using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int a = 5;
        int b = 10;

        //Act
        int resultado = _calc.Somar(a, b);

        //Assert
        Assert.Equal(15, resultado);
    }
}