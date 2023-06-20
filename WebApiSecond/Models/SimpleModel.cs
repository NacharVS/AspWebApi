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

        public string? Name { get; set; }
        public int Age { get; set; }
        public string? EMail { get; set; }

        public static List<SimpleModel> GetModels()
        {
            var list = new List<SimpleModel>();
            list.Add(new SimpleModel("vadim", 33, "vadim@mail.ru"));
            list.Add(new SimpleModel("Victor", 22, "victor@mail.ru"));
            return list;
        }
    }
}
