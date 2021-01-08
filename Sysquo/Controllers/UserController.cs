using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sysquo.API.Data;
using Sysquo.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Sysquo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("getusers")]
        public async Task<ActionResult<IEnumerable<User>>> users()
        {
            return await _context.Users.ToListAsync();

        }
    }
}