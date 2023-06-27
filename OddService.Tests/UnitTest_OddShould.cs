using Odd.Services;
namespace Odd.Tests;

public class UnitTest_OddShould
{
    private readonly OddService oddService;

    public UnitTest_OddShould()
    {
        this.oddService = new OddService();
    }

    [Fact]
    public void IsOdd_InputIs2_ReturnFalse()
    {
        var result = this.oddService.IsOdd(2);
        Assert.False(result, "2 is Even!");
    }

    [Fact]
    public void IsOdd_InputIs1_ReturnTrue()
    {
        var result = this.oddService.IsOdd(1);
        Assert.True(result, "1 is Odd!");
    }
}