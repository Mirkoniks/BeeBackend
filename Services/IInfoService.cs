public interface IInfoService
{
    public Task Add(int peopleCount, int polution);
    public Task<InfoDTO> GetByDate(DateTime date);

}