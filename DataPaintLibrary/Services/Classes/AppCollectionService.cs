using DataPaintLibrary.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;

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
        public async Task<List<User>> GetAllUsers()
        {
            var users = await _sqlService.GetUsers();
            _users = _classBuilderService.BuildUserList(users);

            return _users;
        }

        /// <summary>
        /// Retrieves all owner groups from the data source.
        /// </summary>
        /// <returns>A list of OwnerGroup objects.</returns>
        public async Task<List<OwnerGroup>> GetAllOwnerGroups()
        {
            var ownerGroupsTable = await _sqlService.GetOwnerGroups();
            _ownerGroups = _classBuilderService.BuildOwnerGroups(ownerGroupsTable);

            return _ownerGroups;
        }

        public async Task<List<SecurityGroup>> GetSecurityGroups()
        {
            var securityGroupsTable = await _sqlService.GetSecurityGroups();
            var userSecurityTable = await _sqlService.GetUserSecurity();

            _securityGroups = _classBuilderService.BuildSecurityGroups(securityGroupsTable, userSecurityTable);

            return _securityGroups;
        }

        /// <summary>
        /// Retrieves all data inputs from the data source.
        /// </summary>
        /// <returns>A list of DataInput objects.</returns>
        public async Task<List<DataInput>> GetAllDataInput()
        {
            var dataInputList = await _sqlService.GetSqlDataInputTable();
            var sheetInputList = await _sqlService.GetSqlSheetInputTable();

            _dataInputs = _classBuilderService.BuildDataInputs(dataInputList, sheetInputList);

            return _dataInputs;
        }
    }
}