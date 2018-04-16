using WebserverLab.Server.Common;
using WebserverLab.Server.Http.Contracts;

namespace WebserverLab.Server.Http
{
    public class HttpContext : IHttpContext
    {
        private readonly IHttpRequest request;

        public HttpContext(IHttpRequest request)
        {
            CoreValidator.ThrowIfNull(request, nameof(request));

            this.request = request;
        }
        
        public IHttpRequest Request => this.request;
    }
}
