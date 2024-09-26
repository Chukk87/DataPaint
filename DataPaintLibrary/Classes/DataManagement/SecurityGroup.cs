using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Classes.Input
{
    class SecurityGroup
    {
        int Id { get; set; }
        string GroupName { get; set; }
        List<int> Authorisers { get; set; }
        List<int> Users { get; set; }
        SecurityParameters Parameters { get; set; }
    }
}