public class FactorialTests
{
    [Fact]
    public void Factorial_ReturnsCorrectResult()
    {
        Assert.Equal(120, StudentCode.Factorial(5));
    }
}
