namespace WebserverLab.Server.Http.Contracts
{
    public interface IHttpContext
    {
        IHttpRequest Request { get;  }
    }
}
