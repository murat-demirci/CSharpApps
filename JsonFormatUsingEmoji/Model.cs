using System.Collections.Generic;

namespace JsonFormatUsingEmoji
{
    public class Item
    {
        public string name { get; set; }
        public string art { get; set; }
    }

    public class Category
    {
        public string category { get; set; }
        public List<Item> items { get; set; }
    }
}
