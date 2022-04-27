using Microsoft.AspNetCore.Mvc;
using SimpleBudget.Models;
using SimpleBudget.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntriesController : ControllerBase
    {
        private readonly EntryContext _context;

        public EntriesController(EntryContext context) => _context = context;

        //GET: api/entries
        [HttpGet]
        public ActionResult<IEnumerable<Entry>> GetAllEntries()
        {
            return _context.Entries;
        }
    }
}
