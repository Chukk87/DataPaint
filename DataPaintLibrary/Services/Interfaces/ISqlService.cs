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
        Task<DataTable> GetUsers();
        Task<DataTable> GetOwnerGroups();
        Task<DataTable> GetOwnerGroup(int id);
        Task<DataTable> GetSecurityGroups();
        Task<DataTable> GetUserSecurity();
        Task<DataTable> GetSqlDataInputTable();
        Task<DataTable> GetSqlSheetInputTable();
        Task<AuthenticationType> ValidateUserAsync(string username, string password);
        Task CreateOwnerGroup(string name, string contactEmail, string phoneNumber);
        Task CreateOwnerGroup(OwnerGroup ownerGroup);
        Task UpdateOwnerGroup(OwnerGroup ownerGroup);
        Task DeleteOwnerGroup(OwnerGroup ownerGroup);
        Task CreateSecurityGroup(string securityGroup);
        Task AddUserToSecurityGroup(Guid securityGroupId, Guid userGroupId, UserType userType);
        Task UpdateSecurityGroup(SecurityGroup securityGroup);
    }
}