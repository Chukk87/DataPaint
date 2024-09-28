using System.Threading.Tasks;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ISqlService
    {
        Task<DataTable> GetOwnerGroups();
        Task<DataTable> GetSqlDataInputTable();
        Task<DataTable> GetSqlSheetInputTable();
        Task CreateOwnerGroup(string name, string contactEmail, string phoneNumber);
    }
}
