namespace MeuApp.Api.Services;

public class CalculatorService
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Divisão por zero");

        return a / b;
    }

    public string CheckNumber(int number)
    {
        if (number > 0)
            return "positivo";
        else if (number < 0)
            return "negativo";
        else
            return "zero";
    }
}