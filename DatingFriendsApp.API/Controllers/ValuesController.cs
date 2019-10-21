using System.Collections.Generic;
using System.Threading.Tasks;
using DatingFriendsApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingFriendsApp.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly DataContext _context;
        public ValuesController (DataContext context) {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get () {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
    }
}