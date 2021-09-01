using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinenAndBird.Models;

namespace LinenAndBird.Controllers
{
    [Route("api/hats")] // exposed at ths endpoint
    [ApiController] // an api controller, which returns json or xml
    public class HatsController : ControllerBase
        {
            List<Hat> _hats = new List<Hat>
            {
                new Hat
                {
                    Color ="Blue",
                    Designer = "Charlie",
                    Style = HatStyle.OpenBack
                },
                new Hat
                {
                    Color ="Black",
                    Designer = "Nathan",
                    Style = HatStyle.WideBrim
                },
                new Hat
                {
                    Color ="Magenta",
                    Designer = "Charlie",
                    Style = HatStyle.Normal
                },
            };

        [HttpGet]
        public List<Hat> GetAllHats()
        {
            return _hats;
        }
        // GET/api/hats/styles/1 == all open backed hats

        [HttpGet("styles/{style}")]
        public IEnumerable<Hat> GetHatByStyle(HatStyle style)
        {
            var matches = _hats.Where(hat => hat.Style == style);

            return matches;
        }

        [HttpPost]
        public void AddAHat(Hat newHat)
        {
            _hats.Add(newHat);
        }
    }
}
