using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        // constructor method


        public BakersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Baker> GetAll()
        {
            // no sql required ---go to db there is a table called Bakers
            // _context

            return _context.Bakers;
        }
        [HttpGet("{id}")]
        public ActionResult<Baker> GetById(int id)
        {
            Baker baker = _context.Bakers
            .SingleOrDefault(baker => baker.id == id);
            if (baker == null)
            {
                return NotFound();
            }
            return baker;
        }
        [HttpPost]
        public Baker Post(Baker baker)
        {
            _context.Add(baker);
            _context.SaveChanges();
            return baker;
        }
    }
}
