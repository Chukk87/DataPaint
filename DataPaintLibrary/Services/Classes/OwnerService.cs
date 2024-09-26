using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes.Input;

namespace DataPaintLibrary.Services.Classes
{
    public class OwnerService : IOwnerService
    {
        private List<OwnerGroup> AllGroupOwners = new List<OwnerGroup>();

        public List<OwnerGroup> GetAllOwnerGroups()
        {
            return AllGroupOwners;
        }
    }
}
