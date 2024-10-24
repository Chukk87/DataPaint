using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Services.Classes;

namespace DataPaintDesktop.Forms.OrientationForms
{
    public partial class ExcelExtractionForm : Form
    {
        private readonly IOrchestratorService _orchestratorService;
        private readonly IDataExtractionService _dataExtractionService;
        private readonly OrientationTemplate _orientationTemplate;
        private readonly OrientationSetup _orientationSetupForm;
        private readonly Home _homeForm;

        public ExcelExtractionForm(OrientationSetup orientationSetupForm, Home homeForm, IOrchestratorService orchestratorService, 
                                    IDataExtractionService dataExtractionService, OrientationTemplate orientationTemplate)
        {
            InitializeComponent();

            _orchestratorService = orchestratorService;
            _dataExtractionService = dataExtractionService;
            _orientationTemplate = orientationTemplate;
            _orientationSetupForm = orientationSetupForm;
            _homeForm = homeForm;
        }

        private void FindDirectoryBtn_Click(object sender, EventArgs e)
        {
            if(_orientationSetupForm.InputDataNameTextBox.Text != null && _orientationSetupForm.GroupOwnerComboBox.SelectedItem != null)
            {
                var findFileDialog = new OpenFileDialog();
                findFileDialog.ShowDialog();

                var excelDataSet = _dataExtractionService.GetExcelDataSet(findFileDialog.FileName);
                var dataInput = new DataInput(_orientationSetupForm.InputDataNameTextBox.Text, 0, ExtractionType.Excel, DataType.Dynamic, findFileDialog.FileName);

                _homeForm.LoadFormIntoPrimaryPanel(new ExcelVisualiser(_orchestratorService, _orientationTemplate, excelDataSet, dataInput));

                //if (excelVisualiser.ShowDialog() == DialogResult.OK)
                //{
                //    //InputDataListBox.Items.Clear();

                //    //foreach (var di in _orientationTemplate.DataInputs)
                //    //{
                //    //    _orientationSetupFormInputDataListBox.Items.Add(di.Name);
                //    //}
                //}
            }
            else
            {
                MessageBox.Show("Please input you Input Data Name and select a Owner Group");
            }
        }
    }
}
