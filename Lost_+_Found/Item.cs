using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Item
    {
        public Item(string type, string description)
        {
            this.Type = type;
            Description = description;
        }

        public string Type { get; private set; }
        public string Description { get; private set; }
        
    }
}
