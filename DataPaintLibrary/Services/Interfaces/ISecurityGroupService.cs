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
        /// <summary>
        /// Gets a list of users for a security group
        /// </summary>
        /// <param name="securityGroup"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        List<User> GetUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users);

        /// <summary>
        /// Gets a list of admin users for a specific security group
        /// </summary>
        /// <param name="securityGroup"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        List<User> GetAdminUsersForSecurityGroup(SecurityGroup securityGroup, List<User> users);

        /// <summary>
        /// Adds an admin to security group
        /// </summary>
        /// <param name="securityGroup"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        Task AddAdminToSecurityGroupAsync(SecurityGroup securityGroup, User user);

        /// <summary>
        /// Adds a users to a security group
        /// </summary>
        /// <param name="securityGroup"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        Task AddUserToSecurityGroupAsync(SecurityGroup securityGroup, User user);
    }
}
