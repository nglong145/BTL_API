using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ISanPhamBusiness
    {
        SanPhamModel GetDataById(int id);
        public List<SanPhamModel> GetAll();
        bool Create(SanPhamModel spmodel);
        bool Update(SanPhamModel spmodel);
        bool Delete(int masanpham);
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string tensp);
        public List<SanPhamModel> Search_lowtohigh(int pageIndex, int pageSize, out long total);
        public List<SanPhamModel> Search_hightolow(int pageIndex, int pageSize, out long total);
    }
}
