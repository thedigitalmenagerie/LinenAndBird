using LinenAndBird.DataAccess;
using LinenAndBird.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LinenAndBird.Controllers
{
    [Route("api/birds")]
    [ApiController]
    public class BirdsController : ControllerBase
    {
        BirdRepository _repo;
        public BirdsController()
        {
            _repo = new BirdRepository();
        }

       [HttpGet]
       public IActionResult GetAllBirds()
        {
            return Ok( _repo.GetAll());
        }

        [HttpPost]
        public IActionResult AddBird(Bird newBird)
            // IACTIONRESULT returns with data and/or error
        {
            if (string.IsNullOrWhiteSpace(newBird.Name) || string.IsNullOrWhiteSpace(newBird.Color))
            {
                return BadRequest("Name and Color are required fields when entering a bird");
            }

            _repo.Add(newBird);

            return Created("/api/birds/1", newBird);
        }
    }
}
