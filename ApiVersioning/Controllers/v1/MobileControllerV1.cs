using System.Net;
using ApiVersioning.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    //[Route("api/{v:apiVersion}/mobile")]
    [Route("api/[controller]")]
    public class MobileController : ControllerBase
    {

        [HttpGet("getdata/{key}")]
        public async Task<JsonResult> Get(string key)
        {
            var mobileResponseModel = new MobileResponseModel();
            mobileResponseModel.HttpStatusCode = HttpStatusCode.OK;
            mobileResponseModel.IsSuccess = true;
            mobileResponseModel.Message = "MobileController V1";

            return new JsonResult(mobileResponseModel);
        }

        [HttpPost()]
        [Route("createtemplate")]
        public async Task<JsonResult> CreateTemplate(TemplateModel templateModel)
        {
            var mobileResponseModel = new MobileResponseModel();
            mobileResponseModel.HttpStatusCode = HttpStatusCode.Created;
            mobileResponseModel.IsSuccess = true;

            return new JsonResult(mobileResponseModel);
        }
    }
}
