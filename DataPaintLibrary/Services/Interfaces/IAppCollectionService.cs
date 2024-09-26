using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IAppCollectionService
    {
        Task<List<OwnerGroup>> GetAllOwnerGroups();
        Task<List<DataInput>> GetAllDataInput();
    }
}
