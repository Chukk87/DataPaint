using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Enums;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Classes
{
    public class SecurityGroupService : ISecurityGroupService
    {
        private readonly IAppCollectionService _appCollectionService;
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;

        public SecurityGroupService(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService) 
        {
            _appCollectionService = appCollectionService;
            _loggerService = loggerService;
            _sqlService = sqlService;
        }

        public List<User> GetUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users)
        {
            var baseUsers = users.Where(user => securityGroup.Users.Contains(user.Id)).ToList();

            return baseUsers;
        }

        public List<User> GetAdminUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users)
        {
            var adminUsers = users.Where(user => securityGroup.Admins.Contains(user.Id)).ToList();

            return adminUsers;
        }

        public async Task AddAdminToSecurityGroupAsync(SecurityGroup securityGroup, User user)
        {
            if(!securityGroup.Admins.Contains(user.Id))
            {
                await _sqlService.AddUserToSecurityGroupAsync(securityGroup.Id, user.Id, UserType.Admin);
            }
        }
        public async Task AddUserToSecurityGroupAsync(SecurityGroup securityGroup, User user)
        {
            if (!securityGroup.Users.Contains(user.Id))
            {
                await _sqlService.AddUserToSecurityGroupAsync(securityGroup.Id, user.Id, UserType.User);
            }
        }
    }
}
