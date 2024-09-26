using System.Collections.Generic;
using DataPaintLibrary.Classes.Input;
using System.Data;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IClassBuilderService
    {
        List<OwnerGroup> GroupOwnerClassListBuilder(DataTable Table);
        List<DataInput> DataInputClassListBuilder(DataTable InputDataTable, DataTable InputSheetTable);
    }
}
