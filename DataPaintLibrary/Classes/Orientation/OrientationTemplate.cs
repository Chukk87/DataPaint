using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Classes.Output;
using System.Collections.Generic;

namespace DataPaintLibrary.Classes.Orientation
{
    /// <summary>
    /// Represents a template for report orientation, including input data, format parameters, outputs, and run schedules.
    /// </summary>
    public class OrientationTemplate
    {
        /// <summary>
        /// The name of the report.
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        /// The input data required for the report.
        /// </summary>
        public List<DataInput> DataInputs { get; set; } = new List<DataInput>();

        /// <summary>
        /// The format parameters required to build the outputs.
        /// </summary>
        public List<FormattingStep> FormattingSteps { get; set; } = new List<FormattingStep>();

        /// <summary>
        /// The built outputs of the report.
        /// </summary>
        public List<ReportOutput> ReportOutputs { get; set; } = new List<ReportOutput>();

        /// <summary>
        /// Indicates if the report is run by a user (adhoc run).
        /// </summary>
        public bool IsAdhocRun { get; set; }

        /// <summary>
        /// The schedule on which the report runs.
        /// </summary>
        public List<RunSchedule> RunSchedules { get; set; } = new List<RunSchedule>();

        /// <summary>
        /// Indicates if the report is enabled for execution.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The security groups containing authorizers to change and run the report.
        /// </summary>
        public SecurityGroup SecurityGroups { get; set; }
    }
}