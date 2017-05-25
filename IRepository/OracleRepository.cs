using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OracleRepository : IRepository
    {
        public string GetData()
        {
            return "GetData from OracleRepository";
        }

        public bool Save()
        {
            return false;
        }
    }
}
