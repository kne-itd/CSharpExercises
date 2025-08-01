public class WeekendTests
{
    [Fact]
    public void IsWeekend_ReturnsTrueForSaturday()
    {
        Assert.True(StudentCode.IsWeekend(new DateTime(2025, 8, 2))); // Lørdag
    }

    [Fact]
    public void IsWeekend_ReturnsFalseForWednesday()
    {
        Assert.False(StudentCode.IsWeekend(new DateTime(2025, 8, 6))); // Onsdag
    }
}
