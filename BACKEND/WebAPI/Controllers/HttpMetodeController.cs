using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] // Ruta će se javiti na /api/v1/HttpMetode
    public class HttpMetodeController : ControllerBase
    {
        // Ruta je metoda

        // Ovdje počinje ruta

        [HttpGet]
        public string HelloWorld()
        {
            return "hello";
        }


        // Ovdje završava ruta


        // Ovdje počinje ruta

        [HttpGet]
        [Route("pozdrav")]
        public string HelloWorld(string ime)
        {
            return new StringBuilder().Append("Hello ").Append(ime).ToString();
        }


        // ne može
        //[HttpGet]
        //[Route("pozdrav")]
        private string HelloWorld(string ime, string prezime)
        {
            return new StringBuilder().Append(prezime).Append(ime).ToString();
        }


        // Ovdje završava ruta






        [HttpGet]
        [Route("json")]
        public IActionResult Json()
        {
            // metoda Ok je došla iz nadklase
            return Ok(new { Ime = "Pero", Prezime = "Perić" }); // Ovo nije OOP
        }



        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            // ovdje će iči spremanje u bazu
            return StatusCode(StatusCodes.Status201Created, osoba);
        }



        [HttpPut]
        public IActionResult Put(Osoba o)
        {
            o.Ime = "Promjenio " + o.Ime;
            return Ok(o);
        }



        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return BadRequest(new { poruka="Šifra mora biti veća on 0"});
            }

            return NoContent();
        }

    }
}
