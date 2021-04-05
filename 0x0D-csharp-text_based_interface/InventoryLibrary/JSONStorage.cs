using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    ///<summary>The storage engine for persisting the data.</summary>
    public class JSONStorage
    {
        ///<summary>Contains ALL items, users, inventory tracking, and instances of BaseClass (if you wish).</summary>
        public Dictionary<string, BaseClass> objects {get; set;}

        ///<summary>Returns ALL items stored.</summary>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        ///<summary>Add a new object to the dictionary</summary>
        public void New(BaseClass obj)
        {
            objects.Add($"{obj.GetType()},{obj.id}",obj);
        }

        ///<summary>Saves the stored items to a JSON file.</summary>
        public void Save()
        {
            //Change path if you want to save the files to another path.
            string path = "../storage/inventory_manager.json";
            string jsonObjects = JsonSerializer.Serialize(objects);
            File.WriteAllText(path, jsonObjects);
        }

        ///<summary>Loads all items stored in the JSON file back to the objects dictionary.</summary>
        public void Load()
        {
            string path = "../storage/inventory_manager.json";
            string storageObjects = File.ReadAllText(path);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(storageObjects);
        }
    }
}
