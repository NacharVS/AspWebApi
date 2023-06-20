using MongoDB.Driver;

namespace WebApiSecond.Models
{
    public class DbExtensions
    {
        public static List<SimpleModel> GetAllDocs()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            return collection.Find(x => true).ToList();

        }

        public static void AddDocs(SimpleModel model)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            collection.InsertOne(model);

        }

        public static SimpleModel GetSingleModel(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            return collection.Find(x => x.Name == name).SingleOrDefault();
        }

        public static void ReplaseDoc (string name, SimpleModel newModel)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            collection.ReplaceOne(x=>x.Name == name, newModel);
        }

        public static void DeleteDoc(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            collection.DeleteOne(x => x.Name == name);
        }

        public static void UpdateDoc(string name, int age)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("SimpleModels");
            var collection = database.GetCollection<SimpleModel>("Documents");
            var filter = Builders<SimpleModel>.Update.Set("Age", age);
            collection.UpdateOne(x => x.Name == name, filter);
        }

    }
}
