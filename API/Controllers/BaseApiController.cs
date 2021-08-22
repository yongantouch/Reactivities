using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        

    }
}