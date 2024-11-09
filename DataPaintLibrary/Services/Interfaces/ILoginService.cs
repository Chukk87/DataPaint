using DataPaintLibrary.Classes;
using DataPaintLibrary.Enums;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ILoginService
    {
        Task<UserAuthenticationDetail> ValidateUserAsync(string username, string password);
    }
}