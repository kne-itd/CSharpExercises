public class PrimeTests
{
    [Fact]
    public void IsPrime_ReturnsTrueForPrime()
    {
        Assert.True(StudentCode.IsPrime(7));
    }

    [Fact]
    public void IsPrime_ReturnsFalseForNonPrime()
    {
        Assert.False(StudentCode.IsPrime(9));
    }
}
