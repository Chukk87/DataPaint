using System.Collections.Generic;
using DataPaintLibrary.Classes.Input;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IOwnerService
    {
        List<OwnerGroup> GetAllOwnerGroups();
    }
}