using MeuApp.Api.Services;

public class CalculatorServiceTests
{
    private readonly CalculatorService _service = new();

    [Fact]
    public void Sum_DeveSomarCorretamente()
    {
        var result = _service.Sum(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_DeveDividirCorretamente()
    {
        var result = _service.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_DeveLancarExcecao_QuandoDivisorZero()
    {
        Assert.Throws<ArgumentException>(() => _service.Divide(10, 0));
    }

    [Fact]
    public void CheckNumber_Positivo()
    {
        Assert.Equal("positivo", _service.CheckNumber(5));
    }

    [Fact]
    public void CheckNumber_Negativo()
    {
        Assert.Equal("negativo", _service.CheckNumber(-1));
    }

    [Fact]
    public void CheckNumber_Zero()
    {
        Assert.Equal("zero", _service.CheckNumber(0));
    }
}