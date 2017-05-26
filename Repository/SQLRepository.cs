using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SQLRepository : IRepository
    {
        public string GetData()
        {
            return "GetData from SQLRepository";
        }

        public bool Save()
        {
            return true;
        }
    }
}
