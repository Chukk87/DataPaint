using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Enums;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class OrientationSetup : Form
    {
        private readonly IDataExtractionService _extractionService;
        private readonly ISqlService _sqlService;
        private readonly IOrchestratorService _orchestratorService;

        private OrientationTemplate _orientationTemplate;

        public OrientationSetup(IDataExtractionService dataExtractionService, ISqlService sqlService, IOrchestratorService orchestratorService)
        {
            _extractionService = dataExtractionService;
            _sqlService = sqlService;
            _orchestratorService = orchestratorService;

            InitializeComponent();
        }

        private void FindDirectoryBtn_Click(object sender, EventArgs e)
        {
            var findFileDialog = new OpenFileDialog();
            findFileDialog.ShowDialog();

            var excelDataSet = _extractionService.GetExcelDataSet(findFileDialog.FileName);
            var dataInput = new DataInput(InputDataNameTextBox.Text, 0, ExtractionType.Excel, DataType.Dynamic, findFileDialog.FileName);

            ExcelVisualiser excelVisualiser = new ExcelVisualiser(_orchestratorService, _orientationTemplate, excelDataSet, dataInput);
            excelVisualiser.ShowDialog();

            if (excelVisualiser.ShowDialog() == DialogResult.OK)
            {
                InputDataListBox.Items.Clear();

                foreach(var di in _orientationTemplate.DataInputs)
                {
                    InputDataListBox.Items.Add(di.Name);
                }
            }
        }

        private void CreateBaseTemplateBtn_Click(object sender, EventArgs e)
        {
            _orientationTemplate = new OrientationTemplate()
            {
                ReportName = ReportNameTextBox.Text
            };

            ReportNameTextBox.Enabled = false;
            SecurityGroupComboBox.Enabled = false;
            CreateBaseTemplateBtn.Enabled = false;
        }
    }
}
