using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Services.Classes
{
    public class AppCacheService : IAppCacheService
    {
        private List<SecurityGroup> _securityGroups = new List<SecurityGroup>();

        public List<SecurityGroup> GetSecurityGroups()
        {
            return _securityGroups;
        }

        public void AddSecurityGroup(List<SecurityGroup> securityGroups)
        {
            _securityGroups = securityGroups;
        }
    }
}