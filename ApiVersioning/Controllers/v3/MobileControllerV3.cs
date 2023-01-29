using System.Net;
using ApiVersioning.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v3
{
    [ApiController]
    [ApiVersion("3.0")]
    //[Route("api/{v:apiVersion}/mobile")]
    [Route("api/[controller]")]
    public class MobileController
    {
        [HttpGet("getdata/{key}")]
        public async Task<JsonResult> Get(string key)
        {

            var mobileResponseModel = new MobileResponseModel();
            mobileResponseModel.HttpStatusCode = HttpStatusCode.NotFound;
            mobileResponseModel.IsSuccess = false;
            mobileResponseModel.Message = "MobileController V3";

            return new JsonResult(mobileResponseModel);
        }
    }
}
