public class EvenTests
{
    [Fact]
    public void IsEven_ReturnsTrueForEven()
    {
        Assert.True(StudentCode.IsEven(8));
    }

    [Fact]
    public void IsEven_ReturnsFalseForOdd()
    {
        Assert.False(StudentCode.IsEven(7));
    }
}
