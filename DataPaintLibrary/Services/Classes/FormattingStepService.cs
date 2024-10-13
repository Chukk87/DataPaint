using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Enums;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public class FormattingStepManager : IFormattingStepService
    {
        private List<FormattingStep> _steps = new List<FormattingStep>();

        public void AddStep(FormattingStep step)
        {
            _steps.Add(step);
        }

        public DataTable ApplySteps(DataTable table)
        {
            DataTable formattedTable = table.Copy();

            foreach (var step in _steps)
            {
                switch (step.StepType)
                {
                    case StepType.Filter:
                        formattedTable = ApplyFilter(formattedTable, step);
                        break;
                    case StepType.Sort:
                        formattedTable = ApplySort(formattedTable, step);
                        break;
                    case StepType.Merge:
                        formattedTable = ApplyMerge(formattedTable, step);
                        break;
                    case StepType.Group:
                        formattedTable = ApplyGrouping(formattedTable, step);
                        break;
                    case StepType.Transform:
                        formattedTable = ApplyTransformation(formattedTable, step);
                        break;
                    case StepType.DuplicateRemoval:
                        formattedTable = RemoveDuplicates(formattedTable, step);
                        break;
                }
            }

            return formattedTable;
        }


        //Logic needs to be added
        private DataTable ApplyFilter(DataTable table, FormattingStep step)
        {
            return table;
        }

        private DataTable ApplySort(DataTable table, FormattingStep step)
        {
            return table;
        }

        private DataTable ApplyMerge(DataTable table, FormattingStep step)
        {
            return table;
        }

        private DataTable ApplyGrouping(DataTable table, FormattingStep step)
        {
            return table;
        }

        private DataTable ApplyTransformation(DataTable table, FormattingStep step)
        {
            return table;
        }

        private DataTable RemoveDuplicates(DataTable table, FormattingStep step)
        {
            return table;
        }
    }
}