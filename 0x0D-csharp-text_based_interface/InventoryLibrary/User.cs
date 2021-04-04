using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        private string name;

        public string Name
        {
            get {return name;}
            set {this.name = value;}
        }

        public User (string name = "User") : base()
        {
            this.name = name == default(string) ? "User" : name;
        }

        public User (string id, DateTime date_created, DateTime date_updated, string name) : base(id, date_created, date_updated)
        {
            this.name = name;
        }
    }
}
