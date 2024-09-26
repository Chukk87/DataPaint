using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Classes
{
    class SecurityParameters
    {
        int Id;
        bool AuthorisationToView;
        int AuthorisationViewGroup;
        bool AuthorisationToRun;
        int AuthorisationRunGroup;
        bool AuthorisationToChange;
        int AuthorisationChangeGroup;
    }
}
