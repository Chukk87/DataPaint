using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Classes.Input
{
    class OwnerGroup
    {
        int Id { get; set; }
        string Name { get; set; }
        List<string> ContactEmail { get; set; }
        int PhoneNumber { get; set; }

    }
}
