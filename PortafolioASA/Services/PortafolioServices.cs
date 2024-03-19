using MongoDB.Driver;
using Microsoft.Extensions.Options;
using PortafolioASA.Models;
using Portafolio_ASA.PortafolioASA.Configurations;

namespace Portafolio_ASA.PortafolioASA.Services
{
    public class PortafolioServices
    {
        private readonly IMongoCollection<PortafolioModel> _portafolioCollection;
        
        public PortafolioServices(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
            
            var mongoDB =
            mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
                _portafolioCollection =
                    mongoDB.GetCollection<PortafolioModel>(databaseSettings.Value.CollectionName);
        }

        public async Task<List<PortafolioModel>> GetAsync() =>
            await _portafolioCollection.Find(_ => true).ToListAsync();

       
        
    }
}