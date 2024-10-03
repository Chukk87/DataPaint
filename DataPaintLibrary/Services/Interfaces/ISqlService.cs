using System.Threading.Tasks;
using System.Data;
using DataPaintLibrary.Enums;
using System;
using DataPaintLibrary.Classes.Input;

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
        Task AddUserToSecurityGroup(Guid securityGroupId, Guid userGroupId, UserType userType);
        Task UpdateSecurityGroup(SecurityGroup securityGroup);
    }
}