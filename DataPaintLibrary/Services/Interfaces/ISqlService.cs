using System.Threading.Tasks;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ISqlService
    {
        Task<DataTable> GetUsers();
        Task<DataTable> GetOwnerGroups();
        Task<DataTable> GetSecurityGroups();
        Task<DataTable> GetUserSecurity();
        Task<DataTable> GetSqlDataInputTable();
        Task<DataTable> GetSqlSheetInputTable();
        Task CreateOwnerGroup(string name, string contactEmail, string phoneNumber);
        Task CreateSecurityGroup(string securityGroup);
    }
}