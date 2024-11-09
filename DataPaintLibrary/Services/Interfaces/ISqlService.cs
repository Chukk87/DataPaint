using System.Threading.Tasks;
using System.Data;
using DataPaintLibrary.Enums;
using System;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ISqlService
    {
        Task<DataTable> GetUsersAsync();
        Task<DataTable> GetOwnerGroupsAsync();
        Task<DataTable> GetOwnerGroupAsync(int id);
        Task<DataTable> GetSecurityGroupsAsync();
        Task<DataTable> GetUserSecurityAsync();
        Task<DataTable> GetSqlDataInputTableAsync();
        Task<DataTable> GetSqlSheetInputTableAsync();
        Task CreateOwnerGroupAsync(string name, string contactEmail, string phoneNumber);
        Task CreateOwnerGroupAsync(OwnerGroup ownerGroup);
        Task UpdateOwnerGroupAsync(OwnerGroup ownerGroup);
        Task DeleteOwnerGroupAsync(OwnerGroup ownerGroup);
        Task CreateSecurityGroupAsync(string securityGroup);
        Task AddUserToSecurityGroupAsync(Guid securityGroupId, Guid userGroupId, UserType userType);
        Task UpdateSecurityGroupAsync(SecurityGroup securityGroup);
        Task<UserAuthenticationDetail> ValidateUserAsync(string username, string password);
    }
}