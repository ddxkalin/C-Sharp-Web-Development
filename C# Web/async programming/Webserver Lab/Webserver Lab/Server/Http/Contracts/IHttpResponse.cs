using System.Net;

namespace WebserverLab.Server.Http.Contracts
{
    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }

        HttpHeaderCollection Headers { get; }
    }
}
