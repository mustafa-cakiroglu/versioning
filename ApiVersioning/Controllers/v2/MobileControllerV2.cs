using System.Net;
using ApiVersioning.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v2
{

    [ApiController]
    [ApiVersion("2.0")]
    //[Route("api/{v:apiVersion}/mobile")]
    [Route("api/[controller]")]
    public class MobileController
    {
        [HttpGet("getdata/{key}/{value}")]
        public async Task<JsonResult> Get(string key, string value)
        {

            var mobileResponseModel = new MobileResponseModel();
            mobileResponseModel.HttpStatusCode = HttpStatusCode.NotFound;
            mobileResponseModel.IsSuccess = false;
            mobileResponseModel.Message = "MobileController V2";

            return new JsonResult(mobileResponseModel);
        }

    }
}
