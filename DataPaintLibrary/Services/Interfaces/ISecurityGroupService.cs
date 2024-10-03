using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ISecurityGroupService
    {
        List<User> GetUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users);
        List<User> GetAdminUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users);
        Task AddAdminToSecurityGroup(SecurityGroup securityGroup, User user);
        Task AddUserToSecurityGroup(SecurityGroup securityGroup, User user);
    }
}
