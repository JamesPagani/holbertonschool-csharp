using System;
using System.Collections.Generic;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<BaseClass, string> objects;

        public Dictionary<BaseClass, string> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
