using System.Net;

namespace ApiVersioning.Model
{
    public class MobileResponseModel
    {
        public bool IsSuccess { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
        public string ItemName { get; set; }
        public string Type { get; set; }
    }
}
