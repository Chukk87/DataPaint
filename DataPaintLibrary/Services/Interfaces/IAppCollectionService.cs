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
        Task<List<User>> GetAllUsers();
        /// <summary>
        /// Gets a list of owner groups
        /// </summary>
        /// <returns></returns>
        Task<List<OwnerGroup>> GetAllOwnerGroups();
        Task<List<SecurityGroup>> GetSecurityGroups();
        /// <summary>
        /// Gets a list of all data inputs
        /// </summary>
        /// <returns></returns>
        /// 
        Task<List<DataInput>> GetAllDataInput();
    }
}
