using System.Security.Principal;

namespace CloudMVC.ApplicationCore.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
