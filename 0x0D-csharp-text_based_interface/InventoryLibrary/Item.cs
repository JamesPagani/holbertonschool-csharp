using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    ///<summary>An item that is to be stored.</summary>
    public class Item : BaseClass
    {
        ///<summary>Name of the item.</summary>
        public string name {get;}
        ///<summary>A description of the item.</summary>
        public string description {get; set;}
        ///<summary>Price of the item.</summary>
        public float price {get; set;}

        ///<summary>Tags associated with this item.</summary>
        public List<string> tags;

        ///<summary>Create a new Item to store.</summary>
        public Item(string description, float price, string[] tags, string name = "Item") : base()
        {
            // Should the user, somehow, still pass NULL
            this.name = name == default(string) ? "Item" : name;
            this.description = description;
            this.price = MathF.Round(price, 2);
            this.tags = new List<string>(tags);
        }

        ///<summary>Reload a previously created item.</summary>
        public Item(string id, DateTime date_created, DateTime date_updated, string name, string description, float price, string[] tags): base(id, date_created, date_updated)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = new List<string>(tags);
        }
    }
}
