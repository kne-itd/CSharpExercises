public class ParamsSumTests
{
    [Fact]
    public void SumAll_AddsAllParams()
    {
        Assert.Equal(15, StudentCode.SumAll(1, 2, 3, 4, 5));
    }
}
