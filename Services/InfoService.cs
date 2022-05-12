public class InfoService : IInfoService
{
    private readonly BeesDbContext dbContext;
    public InfoService(BeesDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task Add(int peopleCount, int polution)
    {
        Info info = new Info();

        info.PeopleCount = peopleCount;
        info.Polution = polution;

        await dbContext.Infos.AddAsync(info);

        await dbContext.SaveChangesAsync();
    }

    public async Task<Info> GetByDate(DateTime date)
    {
       Info info = new Info();

        var result = dbContext.Infos
                                .Where(i => i.Date.Year == date.Year)
                                .Where(i => i.Date.Month == date.Month)
                                .Where(i => i.Date.Day == date.Day)
                                .FirstOrDefault();

        info.PeopleCount = result.PeopleCount;
        info.Polution = result.Polution;

        return info;
    }
}