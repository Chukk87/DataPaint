using DataPaintLibrary.Enums;
using DataPaintLibrary.Services.Interfaces;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Classes
{
    public class LoginService : ILoginService
    {
        private readonly ISqlService _sqlService;        

        public LoginService(ISqlService sqlService) 
        { 
            _sqlService = sqlService;
        }

        public async Task<AuthenticationType> ValidateUserAsync(string username, string password)
        {
            //hashpassword here

            //var
            var loginResponse = await _sqlService.ValidateUserAsync(username, password);

            return loginResponse;
        }
    }
}