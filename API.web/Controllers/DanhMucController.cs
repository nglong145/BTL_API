using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private IDanhMucBusiness _danhmucBusiness;
        [Route("create-danhmuc")]
        [HttpPost]
        public DanhMucModel CreateItem([FromBody] DanhMucModel catemodel)
        {
            _danhmucBusiness.Create(catemodel);
            return catemodel;
        }
    }
}
