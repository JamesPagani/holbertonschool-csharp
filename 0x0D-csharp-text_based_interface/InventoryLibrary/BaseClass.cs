using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        private string id {get;}
        private DateTime date_created {get;}
        private DateTime date_updated {get; set;}

        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = this.date_created;
        }

        public BaseClass(string id, DateTime date_created, DateTime date_updated)
        {
            this.id = id;
            this.date_created = date_created;
            this.date_updated = date_updated;
        }
    }
}
