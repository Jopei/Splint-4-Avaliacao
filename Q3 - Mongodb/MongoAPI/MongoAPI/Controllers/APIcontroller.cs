using Microsoft.AspNetCore.Mvc;
using MongoAPI.data;
using MongoAPI.Models;
using System.Threading.Tasks;

namespace MongoAPI.Controllers
{ 
    [ApiController]
    [Route("api/controller")]
    public class APIcontroller : Controller
    {

        private conexaodb database = new conexaodb();
        [HttpPost]
        public async Task<IActionResult> addPedido([FromBody] PedidoModels pedido)
        {
            await database.colecao.InsertOneAsync(pedido);
            return Ok();
        }
        [HttpGet]
        public  IActionResult BucarPedidos()
        {
            return Ok(database.colecao);
        }
    }
}
