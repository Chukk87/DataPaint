using System.Collections.Generic;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IOrchestratorService
    {
        /// <summary>
        /// Runs the orchestrator service for all DataInput items; collects data, formats data, and outputs data.
        /// </summary>
        /// <param name="dataInputs">The list of DataInput objects to process.</param>
        void Run(List<DataInput> dataInputs);

        /// <summary>
        /// Mocks a run for a specific input sheet
        /// </summary>
        /// <param name="mockSheetInput"></param>
        void MockRun(SheetInput mockSheetInput);
    }
}