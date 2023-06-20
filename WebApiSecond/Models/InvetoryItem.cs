namespace WebApiSecond.Models
{
    public class InvetoryItem
    {
        public InvetoryItem(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }

        public string ItemName { get; set; }
        public int ItemCount { get; set; }
    }
}
