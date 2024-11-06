using DataPaintLibrary.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using System.Linq;

namespace DataPaintLibrary.Services.Classes
{
    public class AppCollectionService : IAppCollectionService
    {
        private readonly ISqlService _sqlService;
        private readonly IClassBuilderService _classBuilderService;

        private List<User> _users = new List<User>();
        private List<OwnerGroup> _ownerGroups = new List<OwnerGroup>();
        private List<SecurityGroup> _securityGroups = new List<SecurityGroup>();
        private List<DataInput> _dataInputs = new List<DataInput>();

        public AppCollectionService(ISqlService sqlService, IClassBuilderService classBuilderService)
        {
            _sqlService = sqlService;
            _classBuilderService = classBuilderService;
        }

        /// <summary>
        /// Retrieves all users from the data source
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await _sqlService.GetUsersAsync();
            _users = _classBuilderService.BuildUserList(users);

            return _users;
        }

        /// <summary>
        /// Retrieves all owner groups from the data source.
        /// </summary>
        /// <returns>A list of OwnerGroup objects.</returns>
        public async Task<List<OwnerGroup>> GetAllOwnerGroupsAsync()
        {
            var ownerGroupsTable = await _sqlService.GetOwnerGroupsAsync();
            _ownerGroups = _classBuilderService.BuildOwnerGroups(ownerGroupsTable);

            return _ownerGroups;
        }

        public async Task<OwnerGroup> GetOwnerGroupByIdAsync(int id)
        {
            var ownerGroupTable = await _sqlService.GetOwnerGroupAsync(id);
            var _ownerGroup = _classBuilderService.BuildOwnerGroups(ownerGroupTable).FirstOrDefault();

            return _ownerGroup;
        }

        public async Task<List<SecurityGroup>> GetSecurityGroupsAsync()
        {
            var securityGroupsTable = await _sqlService.GetSecurityGroupsAsync();
            var userSecurityTable = await _sqlService.GetUserSecurityAsync();

            _securityGroups = _classBuilderService.BuildSecurityGroups(securityGroupsTable, userSecurityTable);

            return _securityGroups;
        }

        /// <summary>
        /// Retrieves all data inputs from the data source.
        /// </summary>
        /// <returns>A list of DataInput objects.</returns>
        public async Task<List<DataInput>> GetAllDataInputAsync()
        {
            var dataInputList = await _sqlService.GetSqlDataInputTableAsync();
            var sheetInputList = await _sqlService.GetSqlSheetInputTableAsync();

            _dataInputs = _classBuilderService.BuildDataInputs(dataInputList, sheetInputList);

            return _dataInputs;
        }
    }
}