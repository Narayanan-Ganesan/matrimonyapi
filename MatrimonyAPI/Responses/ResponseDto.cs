using System.Net;

namespace MatrimonyAPI.Responses
{
    public class ResponseDto<T>
    {
        public int StatusCode { get; set; } = (int)HttpStatusCode.OK;
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; }
    }
}
