using DataPaintLibrary.Classes.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ISqlService
    {
        Task<DataTable> GetOwnerGroups();
        Task<DataTable> GetSqlDataInputTable();
        Task<DataTable> GetSqlSheetInputTable();
    }
}
