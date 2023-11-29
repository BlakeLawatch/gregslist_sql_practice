using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_sql_practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {

        private readonly SportsService _sportsService;

        public SportsController(SportsService sportsService)
        {
            _sportsService = sportsService;
        }

        [HttpGet]
        public ActionResult<List<Sport>> GetSports()
        {
            try
            {
                List<Sport> sports = _sportsService.GetSports();
                return Ok(sports);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpGet("{sportId}")]
        public ActionResult<Sport> GetSportById(int sportId)
        {
            try
            {
                Sport sport = _sportsService.GetSportById(sportId);
                return Ok(sport);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }
    }
}