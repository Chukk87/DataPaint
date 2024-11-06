using System.Collections.Generic;
using System.Data;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IClassBuilderService
    {
        /// <summary>
        /// Builds a list of Users from a DataTable
        /// </summary>
        /// <param name="userTable"></param>
        /// <returns></returns>
        List<User> BuildUserList(DataTable userTable);

        /// <summary>
        /// Builds a list of OwnerGroup objects from a DataTable.
        /// </summary>
        /// <param name="table">The DataTable containing the owner group data.</param>
        /// <returns>A list of OwnerGroup objects.</returns>
        List<OwnerGroup> BuildOwnerGroups(DataTable table);

        /// <summary>
        /// Builds a list of security groups from a Security group and User security table
        /// </summary>
        /// <param name="securityTable"></param>
        /// <param name="userSecurity"></param>
        /// <returns></returns>
        List<SecurityGroup> BuildSecurityGroups(DataTable securityTable, DataTable userSecurity);
        
        /// <summary>
        /// Builds a list of DataInput objects from two DataTables: one for DataInput and one for associated SheetInput.
        /// </summary>
        /// <param name="inputDataTable">The DataTable containing the DataInput information.</param>
        /// <param name="inputSheetTable">The DataTable containing the SheetInput information.</param>
        /// <returns>A list of DataInput objects.</returns>
        List<DataInput> BuildDataInputs(DataTable inputDataTable, DataTable inputSheetTable);
    }
}