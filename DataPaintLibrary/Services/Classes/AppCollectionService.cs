﻿using DataPaintLibrary.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Classes
{
    public class AppCollectionService : IAppCollectionService
    {
        private readonly ISqlService _sqlService;
        private readonly IClassBuilderService _classBuilderService;

        private List<OwnerGroup> _ownerGroups = new List<OwnerGroup>();
        private List<DataInput> _dataInputs = new List<DataInput>();

        public AppCollectionService(ISqlService sqlService, IClassBuilderService classBuilderService)
        {
            _sqlService = sqlService;
            _classBuilderService = classBuilderService;
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