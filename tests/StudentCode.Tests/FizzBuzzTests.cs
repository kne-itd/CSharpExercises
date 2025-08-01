public class FizzBuzzTests
{
    [Fact]
    public void FizzBuzz_ReturnsFizzFor3()
    {
        Assert.Equal("Fizz", StudentCode.FizzBuzz(3));
    }

    [Fact]
    public void FizzBuzz_ReturnsBuzzFor5()
    {
        Assert.Equal("Buzz", StudentCode.FizzBuzz(5));
    }

    [Fact]
    public void FizzBuzz_ReturnsFizzBuzzFor15()
    {
        Assert.Equal("FizzBuzz", StudentCode.FizzBuzz(15));
    }

    [Fact]
    public void FizzBuzz_ReturnsNumberFor7()
    {
        Assert.Equal("7", StudentCode.FizzBuzz(7));
    }
}
