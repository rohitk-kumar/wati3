public interface IAddNumberService
{
    Task<ResultDTO> AddNumber(AddDTO dto);
}