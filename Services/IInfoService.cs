public interface IInfoService
{
    public Task Add(int peopleCount, int polution);
    public Task<Info> GetByDate(DateTime date);

}