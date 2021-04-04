using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        private string user_id;
        private string item_id;
        private int quantity;

        public string UserId
        {
            get {return user_id;}
        }
        public string ItemId
        {
            get {return item_id;}
        }
        public int Quantity
        {
            get {return quantity;}
            set {this.quantity = value;}
        }

        public Inventory(string user_id, string item_id, int quantity = 1) : base()
        {

        }

        public Inventory(string id, DateTime date_created, DateTime date_updated, string user_id, string item_id, int quantity) : base(id, date_created, date_updated)
        {
            
        }
    }
}
