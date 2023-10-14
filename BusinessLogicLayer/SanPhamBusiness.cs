using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SanPhamBusiness:ISanPhamBusiness
    {
        private ISanPhamRepository _res;
        public SanPhamBusiness(ISanPhamRepository res)
        {
            _res = res;
        }

        public SanPhamModel GetDataById (int id)
        {
            return _res.GetDataById(id);
        }
        public SanPhamModel GetAll()
        {
            return _res.GetAll();
        }
        public bool Create(SanPhamModel spmodel)
        {
            return _res.Create(spmodel);
        }
    }
}
