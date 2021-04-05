using System;

namespace InventoryLibrary
{
    ///<summary>Inventory tracking.</summary>
    public class Inventory : BaseClass
    {
        ///<summary>The User's ID.</summary>
        public string user_id {get;}
        ///<summary>The Item's ID.</summary>
        public string item_id {get;}
        ///<summary>Amount of items.</summary>
        public int quantity {get; set;}

        ///<summary>Create a new instance of the inventory tracking.</summary>
        public Inventory(string user_id, string item_id, int quantity = 1) : base()
        {

        }

        ///<summary>Reload a stored instance of Inventory.</summary>
        public Inventory(string id, DateTime date_created, DateTime date_updated, string user_id, string item_id, int quantity) : base(id, date_created, date_updated)
        {
            
        }
    }
}
