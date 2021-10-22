using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EFNet5GestionClientAPI.Models.DTO.Requests;

using EFNetCore5AccessDataLibrairy.DatabaseContext;
using EFNetCore5AccessDataLibrairy.EntityModels;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFNet5GestionClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly APIDatabaseContext _context;

        public UserController(APIDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.User.Include(client => client.ClientsUser).ToList();
        }

        [HttpPost]
        public IActionResult Post(User newUser)
        {
            if (_context.User == null)
                return NotFound("Aucune donnees fournie");

            newUser.Id = Guid.NewGuid();
            _context.User.Add(newUser);
            _context.SaveChanges();
            return Ok("User created successfully");
        }
    }
}