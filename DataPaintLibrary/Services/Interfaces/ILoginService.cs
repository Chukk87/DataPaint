using DataPaintLibrary.Enums;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ILoginService
    {
        Task<AuthenticationType> ValidateUserAsync(string username, string password);
    }
}