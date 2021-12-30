using MongoDB.Driver;
using MongoAPI.Models;
namespace MongoAPI.data
{
    public class conexaodb
    {
        public readonly string ConnectionString = "mongodb://localhost:27017";
        public IMongoClient user { get; private set; }
        public IMongoDatabase mongo { get; private set; }
        public IMongoCollection<PedidoModels> colecao { get; private set; }

        public conexaodb()
        {
            user = new MongoClient(ConnectionString);
            mongo = user.GetDatabase("Auditoria");
            colecao = mongo.GetCollection<PedidoModels>("Pedidos");
        }
    }
}
