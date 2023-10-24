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
        public List<SanPhamModel> GetAll()
        {
            return _res.GetAll();
        }
        public bool Create(SanPhamModel spmodel)
        {
            return _res.Create(spmodel);
        }

        public bool Update (SanPhamModel spmodel)
        {
            return _res.Update(spmodel);
        }

        public bool Delete(int masanpham)
        {
            return _res.Delete(masanpham);
        }
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string tensp)
        {
            return _res.Search(pageIndex, pageSize, out total, tensp);
        }
        public List<SanPhamModel> Search_lowtohigh(int pageIndex, int pageSize, out long total)
        {
            return _res.Search_lowtohigh(pageIndex,pageSize,out total); 
        }
        public List<SanPhamModel> Search_hightolow(int pageIndex, int pageSize, out long total)
        {
            return _res.Search_hightolow(pageIndex, pageSize, out total);
        }
    }
}
