namespace WebserverLab.Server.Enums
{
    public enum HttpRequestMethod
    {
        Ok = 200,
        MovedPermanently = 301,
        Found = 302,
        MovedTemporarily = 303,
        NotAuthorized = 401,
        NotFound = 404,
        InternatServerError = 500
    }
}
