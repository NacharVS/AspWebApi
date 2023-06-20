using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiSecond.Models
{
    public class SimpleModel
    {
        public SimpleModel(string? name, int age, string? eMail)
        {
            Name = name;
            Age = age;
            EMail = eMail;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? EMail { get; set; }

        public static List<SimpleModel> GetModels()
        {
            var list = new List<SimpleModel>();
            list.Add(new SimpleModel("vadim", 33, "vadim@mail.ru"));
            list.Add(new SimpleModel("Victor", 22, "victor@mail.ru"));
            list.Add(new SimpleModel("Grigoriy", 22, "victor@mail.ru"));
            list.Add(new SimpleModel("Georgiy", 22, "victor@mail.ru"));
            list.Add(new SimpleModel("Nick", 22, "victor@mail.ru"));
            return list;
        }

        public void ChangeAge(int newAge)
        {
            Age = newAge;
        }
    }
}
