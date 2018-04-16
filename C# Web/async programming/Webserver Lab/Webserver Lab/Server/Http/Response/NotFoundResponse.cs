namespace WebServer.Server.Http.Response
{
    using WebserverLab.Server.Common;
    using WebserverLab.Server.Enums;
    using WebserverLab.Server.Http;
    using WebserverLab.Server.Http.Response;

    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
        {
            CoreValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;

            this.Headers.Add(HttpHeader.Location, redirectUrl);
        }
    }
}