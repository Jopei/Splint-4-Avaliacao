using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pokemon.Tiposdados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pokemon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class pokemonController : ControllerBase
    {
        int codid = 1;
        static List<Pokemons> pokemon = new List<Pokemons>();

        [HttpPost]
        public IActionResult Post([FromBody] Pokemons Pokemon)//Inserir 
        {

            Pokemon.Codigo = codid;
            pokemon.Add(Pokemon);
            Console.WriteLine("Você capturou o novo pokemon!!");
            codid++;
            return Ok();
        }

        [HttpGet]
        public IActionResult Get() //Consultar
        {
            Console.WriteLine("Mostrando seu time pokemon");
            return Ok(pokemon);
        }

        [HttpDelete("123/{cod}")] // Remover 
        public IActionResult Delete(int cod)
        {

            Console.WriteLine("O pokemon de numero: " + cod + ", Foi removido da sua lista");
            pokemon.Remove(pokemon.Find(x => x.Codigo == cod));
            return NoContent();
        }
    }
}
