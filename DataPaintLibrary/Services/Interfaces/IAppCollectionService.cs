using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IAppCollectionService
    {
        /// <summary>
        /// Gets a list of users
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetAllUsersAsync();
        
        /// <summary>
        /// Gets a list of owner groups
        /// </summary>
        /// <returns></returns>
        Task<List<OwnerGroup>> GetAllOwnerGroupsAsync();
        
        /// <summary>
        /// Gets an owner group by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OwnerGroup> GetOwnerGroupByIdAsync(int id);
        
        /// <summary>
        /// Gets a list of security groups
        /// </summary>
        /// <returns></returns>
        Task<List<SecurityGroup>> GetSecurityGroupsAsync();
        
        /// <summary>
        /// Gets a list of all data inputs
        /// </summary>
        /// <returns></returns>
        /// 
        Task<List<DataInput>> GetAllDataInputAsync();
    }
}
