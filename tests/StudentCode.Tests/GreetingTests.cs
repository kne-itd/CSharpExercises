public class GreetingTests
{
    [Fact]
    public void Greet_ReturnsCorrectGreeting()
    {
        Assert.Equal("Hej, Anna!", StudentCode.Greet("Anna"));
    }
}
