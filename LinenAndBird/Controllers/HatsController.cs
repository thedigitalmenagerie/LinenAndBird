using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LinenAndBird.Models;
using LinenAndBird.DataAccess;

namespace LinenAndBird.Controllers
{
    [Route("api/hats")] // exposed at ths endpoint
    [ApiController] // an api controller, which returns json or xml
    public class HatsController : ControllerBase
     {
        HatRepository _repo;
        public HatsController()
        {
            _repo = new HatRepository();
        }
        [HttpGet]
        public List<Hat> GetAllHats()
        {
            return _repo.GetAll(); 
        }
        // GET/api/hats/styles/1 == all open backed hats

        [HttpGet("styles/{style}")]
        public IEnumerable<Hat> GetHatByStyle(HatStyle style)
        {
            return _repo.GetByStyle(style);
        }

        [HttpPost]
        public void AddAHat(Hat newHat)
        {
            _repo.Add(newHat);
        }
    }
}
