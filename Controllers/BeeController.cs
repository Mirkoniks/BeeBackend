using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
 
namespace Beebackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BeeController : ControllerBase
{
    private readonly BeesDbContext dbContext;
    private readonly IInfoService infoService;
    public BeeController(BeesDbContext dbContext, IInfoService infoService)
    {
        this.dbContext = dbContext;
        this.infoService = infoService;

    }

    [HttpPost("PostData")]
    public ActionResult PostData([FromQuery] int peopleCount, int polution)
    {
        infoService.Add(peopleCount, polution);

        Console.WriteLine(dbContext.Infos.FirstOrDefault().PeopleCount);

        return StatusCode(200);
    }

    [HttpGet("GetData")]
    public async Task<ActionResult<InfoDTO>> GetData([FromQuery] int year, int month, int day)
    {
        DateTime date = new DateTime(year, month,day);

        InfoDTO info = await infoService.GetByDate(date);

        return info;
    }
}
