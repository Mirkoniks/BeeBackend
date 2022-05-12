using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Beebackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BeeController : ControllerBase
{
    public BeeController()
    {
        
    }

    [HttpPost(Name = "PostData")]
    public ActionResult<IEnumerable<int>> PostData([FromQuery] int peopleCount, int polution)
    {
        List<int> data = new List<int>();

        data.Add(peopleCount);

        data.Add(polution);

        return data;
    }
}
