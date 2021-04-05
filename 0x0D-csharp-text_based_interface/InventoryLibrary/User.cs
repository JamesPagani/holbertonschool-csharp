using System;

namespace InventoryLibrary
{
    ///<summary>An user, owner of an item.</summary>
    public class User : BaseClass
    {
        ///<summary>User's name.</summary>
        public string name {get; set;}

        ///<summary>Create a new user</summary>
        public User (string name = "User") : base()
        {
            this.name = name == default(string) ? "User" : name;
        }

        ///<summary>Reload a previously created user</summary>
        public User (string id, DateTime date_created, DateTime date_updated, string name) : base(id, date_created, date_updated)
        {
            this.name = name;
        }
    }
}
