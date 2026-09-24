public class FizzBuzzValueTests
{
    [Theory]
    [InlineData(6, 2, 3, "FizzBuzz")]
    [InlineData(4, 2, 3, "Fizz")]
    [InlineData(9, 2, 3, "Buzz")]
    [InlineData(7, 2, 3, "7")]
    public void FizzBuzzValue_DecisionTableRules_ReturnsExpected(int i, int x, int y, string expected)
    {
        var result = Program.FizzBuzzValue(i, x, y);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(4, 2, 4, "FizzBuzz")]
    [InlineData(12, 4, 6, "FizzBuzz")]
    public void FizzBuzzValue_DivisorsWithCommonFactor_ReturnsFizzBuzz(int i, int x, int y, string expected)
    {
        Assert.Equal(expected, Program.FizzBuzzValue(i, x, y));
    }

    [Theory]
    [InlineData(1, 2, 3, "1")]
    [InlineData(100, 3, 5, "Buzz")]
    [InlineData(1, 1, 2, "Fizz")]
    [InlineData(97, 2, 3, "97")]
    public void FizzBuzzValue_BoundaryValues_ReturnsExpected(int i, int x, int y, string expected)
    {
        Assert.Equal(expected, Program.FizzBuzzValue(i, x, y));
    }
}

public class AreValidConstraintsTests
{
    [Fact]
    public void AreValidConstraints_TypicalValidInput_ReturnsTrue()
    {
        Assert.True(Program.AreValidConstraints(2, 3, 7));
    }

    [Fact]
    public void AreValidConstraints_NegativeX_ReturnsFalse()
    {
        Assert.False(Program.AreValidConstraints(-1, 3, 7));
    }

    [Theory]
    [InlineData(1, 2, 5)]
    [InlineData(2, 3, 5)]
    [InlineData(2, 5, 5)]
    [InlineData(2, 3, 100)]
    [InlineData(1, 2, 2)]
    public void AreValidConstraints_OnValidBoundary_ReturnsTrue(int x, int y, int n)
    {
        Assert.True(Program.AreValidConstraints(x, y, n));
    }

    [Theory]
    [InlineData(0, 3, 5)]
    [InlineData(3, 3, 5)]
    [InlineData(4, 3, 5)]
    [InlineData(2, 6, 5)]
    [InlineData(2, 3, 101)]
    public void AreValidConstraints_JustOutsideBoundary_ReturnsFalse(int x, int y, int n)
    {
        Assert.False(Program.AreValidConstraints(x, y, n));
    }
}