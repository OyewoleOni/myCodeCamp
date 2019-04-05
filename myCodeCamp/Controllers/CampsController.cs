using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myCodeCamp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        public IActionResult Get()
        {
            return  Ok(new { Name = "Oni", FavoriteColor = "Blue" });
        }
    }
}