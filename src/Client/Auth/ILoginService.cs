using System.Threading.Tasks;

namespace ListGeneratorBlazor.Client.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
