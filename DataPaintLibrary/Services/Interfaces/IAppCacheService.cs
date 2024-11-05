using DataPaintLibrary.Classes.Input;
using System.Collections.Generic;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IAppCacheService
    {
        List<SecurityGroup> GetSecurityGroups();
        void AddSecurityGroup(List<SecurityGroup> securityGroups);
    }
}
