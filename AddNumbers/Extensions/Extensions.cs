public static class Extentsions
{
    public static void Endpoints(this WebApplication webApplication)
    {
        webApplication.MapPost("/add",AddNumbers);
    }

    public static async Task<IResult> AddNumbers(IAddNumberService service, AddNumDTO dto)
    {
        var resDTO = await service.AddNumber(dto);

        return Results.Created("/add",resDTO);

    }
}