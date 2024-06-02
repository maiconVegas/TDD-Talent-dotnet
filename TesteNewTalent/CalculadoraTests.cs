using NewTalent.Services;

namespace TesteNewTalent;

public class CalculadoraTests
{

    public Calculadora construirClasse()
    {
        string data = "02/06/2024";
        Calculadora calc = new Calculadora("02/06/2024");

        return calc;
    }

    private Calculadora _calc;

    public CalculadoraTests()
    {
        //_calc = new Calculadora();
        _calc = construirClasse();
    }

    [Fact]
    public void Test1ParaSomar()
    {
        //Calculadora calc = new Calculadora();
        // Calculadora calc = construirClasse();

        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void Test2ComTheoryEComSomar(int num1, int num2, int resultado)
    {
        //Calculadora calc = new Calculadora();

        // Arrange
        // int num1 = 5;
        // int num2 = 10;

        // Act
        int resultadoCalculadora = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void Test3ComTheoryEComMultiplicar(int num1, int num2, int resultado)
    {
        //Calculadora calc = new Calculadora();

        // Arrange
        // int num1 = 5;
        // int num2 = 10;

        // Act
        int resultadoCalculadora = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void Test4ComTheoryEComDividir(int num1, int num2, int resultado)
    {
        //Calculadora calc = new Calculadora();

        // Arrange
        // int num1 = 5;
        // int num2 = 10;

        // Act
        int resultadoCalculadora = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void Test5ComTheoryEComSubtrair(int num1, int num2, int resultado)
    {
        //Calculadora calc = new Calculadora();

        // Arrange
        // int num1 = 5;
        // int num2 = 10;

        // Act
        int resultadoCalculadora = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {

        // Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {

        _calc.Somar(1, 2);
        _calc.Somar(2, 8);
        _calc.Somar(3, 7);
        _calc.Somar(4, 1);

        var lista = _calc.Historico();

        // Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}