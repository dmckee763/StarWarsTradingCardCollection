using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarWarsTradingCardCollectionAPI.Models;

namespace StarWarsTradingCardCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionOverviewController : ControllerBase
    {
        private readonly StarWarsTradingCardCollectionContext _context;

        public CollectionOverviewController(StarWarsTradingCardCollectionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Set>>> GetCollectionOverview()
        {          
            var sets = await _context.Set
               // .Include(x => x.Series)
                    //.ThenInclude(x => x.Card)
                .ToListAsync();

            return sets;
        }
    }
}
