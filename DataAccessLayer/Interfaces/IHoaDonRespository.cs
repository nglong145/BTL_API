using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface IHoaDonRespository
    {
        bool Create(HoaDonModel model);
        //bool Update(HoaDonModel model);
    }
}
