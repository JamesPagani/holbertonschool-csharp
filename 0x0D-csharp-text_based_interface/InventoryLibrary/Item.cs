using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        private string name;
        private string description;
        private float price;
        public List<string> tags;

        public string Name
        {
            get {return name;}
            set {this.name = value;}
        }

        public string Description
        {
            get {return description;}
            set {this.description = value;}
        }

        public float Price
        {
            get {return price;}
            set {this.price = value;}
        }

        public Item(string name = "Item", string description, float price, string[] tags) : base()
        {
            // Should the user, somehow, still pass NULL
            this.name = name == default(string) ? "Item" : name;
            this.description = description;
            this.price = MathF.Round(price, 2);
            this.tags = new List<string>(tags);
        }

        public Item(string id, DateTime date_created, DateTime date_updated, string name, string description, float price, string[] tags): base(id, date_created, date_updated)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = new List<string>(tags);
        }
    }
}
