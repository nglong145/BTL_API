using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer;
using DataModel;

namespace API_admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private IDanhMucBusiness _danhmucBusiness;
        public DanhMucController(IDanhMucBusiness danhmucBusiness)
        {
            _danhmucBusiness = danhmucBusiness;
        }
        [Route("create-danhmuc")]
        [HttpPost]
        public DanhMucModel CreateItem([FromBody] DanhMucModel catemodel)
        {
            _danhmucBusiness.Create(catemodel);
            return catemodel;
        }
    }
}
