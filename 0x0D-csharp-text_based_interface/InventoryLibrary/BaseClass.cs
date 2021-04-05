using System;

namespace InventoryLibrary
{
    ///<summary>A class that contains common info for each inventory instance.</summary>
    public class BaseClass
    {
        ///<summary>This instance ID (GUID).</summary>
        public string id {get;}
        ///<summary>The date this instance was created.</summary>
        public DateTime date_created {get;}
        ///<summary>The date this instance's info was updated.</summary>
        public DateTime date_updated {get; set;}

        ///<summary>Create a new instance of BaseClass.</summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = this.date_created;
        }

        ///<summary>Used when reloading a stored instance.</summary>
        public BaseClass(string id, DateTime date_created, DateTime date_updated)
        {
            this.id = id;
            this.date_created = date_created;
            this.date_updated = date_updated;
        }
    }
}
