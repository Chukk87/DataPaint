using System;
using System.Collections.Generic;
using System.Linq;
using DataPaintLibrary.Classes.Input;
using System.Data;
using DataPaintLibrary.Services.Interfaces;

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
    }
}
