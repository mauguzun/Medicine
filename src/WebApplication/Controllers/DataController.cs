using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Content("Index");
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Secret()
        {
            return Content("Secret");
        }

    }
}
