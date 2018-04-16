using System.Collections.Generic;
using WebserverLab.Server.Enums;

namespace WebserverLab.Server.Http.Contracts
{
    public interface IHttpRequest
    {
        IDictionary<string, string> FormData { get; }

        HttpHeaderCollection Headers { get; }

        string Path { get;  }

        IDictionary<string, string> QueryParameters { get; }

        HttpRequestMethod Method { get; }

        string Url { get; }

        IDictionary<string, string> UrlParameteres { get; }

        void addUrlParameter(string key, string value);
    }
}
