using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;
using System.Reflection;

namespace BusinessLogicLayer
{
    public class HoaDonBusiness : IHoaDonBusiness
    {
        private IHoaDonRespository _res;
        public HoaDonBusiness(IHoaDonRespository res)
        {
            _res = res;
        }

       
        public bool Create(HoaDonModel model)
        {
            return _res.Create(model);
        }
        //public bool Update(HoaDonModel model)
        //{
        //    return _res.Update(model);
        //}
      
    }
}