using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cego.Controllers
{
    [Route("api")]
    [ApiController]
    public class pokusController : ControllerBase
    {
        [HttpGet("pokus/abc")]
        public IActionResult abc(string jmeno ,string prijmeni)
        {
            string obracene = prijmeni + jmeno;
            return Unauthorized(obracene);
        }
        [HttpGet("GetVal")]

        public IActionResult GetVal(int cislo1, int cislo2)
        {
            if (cislo1 + cislo2 < 1) {
                Console.WriteLine("Nulou nelze delit");
            }

            int vysledek = cislo1 / cislo2;
            return Unauthorized(vysledek);
        }
        [HttpGet("GetVal2")]
        public IActionResult GetVal2(int cislo = 20, int cislo1 = 2)
        {
            int vypocet = cislo / cislo1;
            return NotFound(vypocet);
        }
    }
}
