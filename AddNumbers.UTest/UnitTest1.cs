namespace AddNumbers.UTest;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        AddNumberService numberService = new AddNumberService();
        AddNumDTO dto = new AddNumDTO()
        {
            Num1 = 10,
            Num2 = 20
        };
        var result = await numberService.AddNumber(dto);

        Assert.Equal(30,result.Result);

    }
}