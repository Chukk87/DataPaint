using DataPaintLibrary.Classes.Orientation;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IFormattingStepService
    {
        void AddStep(FormattingStep step);
        DataTable ApplySteps(DataTable table);
    }
}