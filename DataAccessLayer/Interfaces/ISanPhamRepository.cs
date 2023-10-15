using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface ISanPhamRepository
    {
        SanPhamModel GetDataById(int id);
        SanPhamModel GetAll();
        bool Create (SanPhamModel spmodel);
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string tensp);
    }
}
