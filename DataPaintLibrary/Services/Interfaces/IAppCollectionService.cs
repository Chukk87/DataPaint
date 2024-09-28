using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IAppCollectionService
    {
        /// <summary>
        /// Gets a list of owner groups
        /// </summary>
        /// <returns></returns>
        Task<List<OwnerGroup>> GetAllOwnerGroups();
        /// <summary>
        /// Gets a list of all data inputs
        /// </summary>
        /// <returns></returns>
        Task<List<DataInput>> GetAllDataInput();
    }
}
