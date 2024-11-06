using DataPaintLibrary.Classes.Orientation;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IFormattingStepService
    {
        /// <summary>
        /// Adds a formatting step
        /// </summary>
        /// <param name="step"></param>
        void AddStep(FormattingStep step);

        /// <summary>
        /// Applys all the recorded steps to a datatable
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        DataTable ApplySteps(DataTable table);
    }
}