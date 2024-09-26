using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPaintLibrary.Classes.Input;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IClassBuilderService
    {
        List<OwnerGroup> GroupOwnerClassListBuilder(DataTable Table);
    }
}
