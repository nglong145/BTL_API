using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPhamBusiness _spBusiness;
        public SanPhamController(ISanPhamBusiness sanphamBusiness)
        {
            _spBusiness = sanphamBusiness;
        }
        [Route("create-sanpham")]
        [HttpPost]
        public SanPhamModel CreateItem([FromBody] SanPhamModel spmodel)
        {
            _spBusiness.Create(spmodel);
            return spmodel;
        }

        [Route("update-sanpham")]
        [HttpPost]
        public SanPhamModel UpdateItem([FromBody] SanPhamModel spmodel)
        {
            _spBusiness.Update(spmodel);
            return spmodel;
        }

        [Route("delete-sanpham")]
        [HttpDelete]
        public bool DeleteItem([FromBody] int masanpham)
        {
            return _spBusiness.Delete(masanpham); 
        }
    }
}
