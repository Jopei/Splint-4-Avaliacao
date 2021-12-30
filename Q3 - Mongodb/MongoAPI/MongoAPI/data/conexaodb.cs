using MongoDB.Driver;
using MongoAPI.Models;
namespace MongoAPI.data
{
    public class conexaodb
    {
        public readonly string ConnectionString = "mongodb://localhost:27017";//Localhost padrao 
        public IMongoClient user { get; private set; }
        public IMongoDatabase mongo { get; private set; }
        public IMongoCollection<PedidoModels> colecao { get; private set; } //Itens 

        public conexaodb()
        {
            user = new MongoClient(ConnectionString); 
            mongo = user.GetDatabase("Auditoria");//Banco de dados
            colecao = mongo.GetCollection<PedidoModels>("Pedidos");//Tabela 
        }
    }
}
