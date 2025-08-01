using MongoDB.Bson;
using MongoDB.Driver;

namespace MyPortfolio.Repositories
{
    public class Register_repository
    {
        private readonly IMongoCollection<BsonDocument> _accountCollection;

        public Register_repository(IMongoDatabase database)
        {
            _accountCollection = database.GetCollection<BsonDocument>("Account_table");
        }

        public async Task<bool> CreateAccountAsync(string FirstName, string LastName, string Email, string Password)
        {
            var document = new BsonDocument
            {
                { "_id", DateTime.Now.Year + "-" + (FirstName + LastName).ToUpper().Replace(" ", "") },
                { "AccountType", "USER" },
                { "FirstName", FirstName },
                { "LastName", LastName },
                { "Email", Email },
                { "Password", BCrypt.Net.BCrypt.HashPassword(Password) },
                { "isOnline", false },
                { "isDeleted", false }
            };

            await _accountCollection.InsertOneAsync(document);
            return true;
        }
    }
}