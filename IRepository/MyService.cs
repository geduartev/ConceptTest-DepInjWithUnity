using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MyService
    {
        private readonly IRepository _IRepository;

        public MyService(IRepository irepository)
        {
            _IRepository = irepository;
        }

        public string GetData()
        {
            return _IRepository.GetData();
        }

        public bool Save()
        {
            return _IRepository.Save();
        }
    }
}
