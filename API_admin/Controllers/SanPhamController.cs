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
        [Route("create-sanpham")]
        [HttpPost]
        public SanPhamModel CreateItem([FromBody] SanPhamModel spmodel)
        {
            _spBusiness.Create(spmodel);
            return spmodel;
        }
    }
}
