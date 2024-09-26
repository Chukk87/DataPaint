﻿using System.Collections.Generic;
using System.Data;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IClassBuilderService
    {
        /// <summary>
        /// Builds a list of OwnerGroup objects from a DataTable.
        /// </summary>
        /// <param name="table">The DataTable containing the owner group data.</param>
        /// <returns>A list of OwnerGroup objects.</returns>
        List<OwnerGroup> BuildOwnerGroups(DataTable table);

        /// <summary>
        /// Builds a list of DataInput objects from two DataTables: one for DataInput and one for associated SheetInput.
        /// </summary>
        /// <param name="inputDataTable">The DataTable containing the DataInput information.</param>
        /// <param name="inputSheetTable">The DataTable containing the SheetInput information.</param>
        /// <returns>A list of DataInput objects.</returns>
        List<DataInput> BuildDataInputs(DataTable inputDataTable, DataTable inputSheetTable);
    }
}