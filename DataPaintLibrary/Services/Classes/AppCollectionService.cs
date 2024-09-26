using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes.Input;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Classes
{
    public class AppCollectionService : IAppCollectionService
    {
        private readonly ISqlService _sqlService;
        private readonly IClassBuilderService _classBuilderService;

        private List<OwnerGroup> AllGroupOwners = new List<OwnerGroup>();
        private List<DataInput> AllDataInput = new List<DataInput>();

        public AppCollectionService(ISqlService sqlService, ClassBuilderService classBuilderService)
        {
            _sqlService = sqlService;
            _classBuilderService = classBuilderService;
        }

        public async Task<List<OwnerGroup>> GetAllOwnerGroups()
        {
            var ownerGroupsTable = await _sqlService.GetOwnerGroups();
            AllGroupOwners = _classBuilderService.GroupOwnerClassListBuilder(ownerGroupsTable);

            return AllGroupOwners;
        }

        public async Task<List<DataInput>> GetAllDataInput()
        {
            var dataInputList = await _sqlService.GetSqlDataInputTable();
            var sheetInputList = await _sqlService.GetSqlSheetInputTable();

            AllDataInput = _classBuilderService.DataInputClassListBuilder(dataInputList, sheetInputList);

            return AllDataInput;
        }
    }
}
