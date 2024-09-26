using System;
using System.Collections.Generic;
using System.Linq;
using DataPaintLibrary.Classes.Input;
using System.Data;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Enums;

namespace DataPaintLibrary.Services.Classes
{
    public class ClassBuilderService : IClassBuilderService
    {
        public List<OwnerGroup> GroupOwnerClassListBuilder (DataTable Table)
        {
            var GroupOwnerList = new List<OwnerGroup>();

            foreach(DataRow dr in Table.AsEnumerable())
            {
                var ownerGroup = new OwnerGroup()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = Convert.ToString(dr["GroupName"]),
                    ContactEmail = Convert.ToString(dr["ContactEmail"]),
                    PhoneNumber = Convert.ToString(dr["PhoneNumber"])
                };

                GroupOwnerList.Add(ownerGroup);
            }

            return GroupOwnerList;
        }

        public List<DataInput> DataInputClassListBuilder (DataTable InputDataTable, DataTable InputSheetTable)
        {
            var DataInputList = new List<DataInput>();

            foreach (DataRow idt in InputDataTable.AsEnumerable())
            {
                var dataInput = new DataInput()
                {
                    Id = Convert.ToInt32(idt["Id"]),
                    Name = Convert.ToString(idt["InputName"]),
                    OwnerGroupId = Convert.ToInt32(idt["OwnerGroupId"]),
                    ExtractionType = (ExtractionType)Convert.ToInt32(idt["ExtractionTypeId"]),
                    Type = (DataType)Convert.ToInt32(idt["DataTypeId"]),
                    Location = Convert.ToString(idt["Location"])
                };

                var filterInputSheetTable = InputSheetTable.AsEnumerable()
                            .Where(row => row.Field<int>("DataInputId") == dataInput.Id);
                
                //Now need to build the sheets from a data table
                foreach (DataRow ist in filterInputSheetTable.AsEnumerable())
                {
                    var sheet = new SheetInput()
                    {
                        SheetName = Convert.ToString(ist["SheetName"]),
                        IncludeHeader = Convert.ToBoolean(ist["IncludeHeader"]),
                        StartRow = Convert.ToInt32(idt["StartRow"]),
                        EndRow = Convert.ToInt32(idt["EndRow"]),
                        StartColumn = Convert.ToInt32(idt["StartColumn"]),
                        EndColumn = Convert.ToInt32(idt["EndColumn"])
                    };

                    dataInput.Sheets.Add(sheet);
                }

                DataInputList.Add(dataInput);
            }

            return DataInputList;
        }
    }
}