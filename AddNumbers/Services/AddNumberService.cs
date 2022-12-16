public class AddNumberService : IAddNumberService
{
    public async Task<ResultDTO> AddNumber(AddNumDTO dto)
    {
       ResultDTO resDTO = new ResultDTO()
       {
            Num1 = dto.Num1,
            Num2 = dto.Num2,
            Result = dto.Num1 + dto.Num2
       };
        //add mongo db stuff
       return resDTO;
    }
}