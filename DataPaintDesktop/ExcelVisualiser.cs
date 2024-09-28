using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class ExcelVisualiser : Form
    {
        private readonly IOrchestratorService _orchestratorService;
        private OrientationTemplate _orientationTemplate;

        private DataSet _dataSet;
        private List<SheetInput> _sheetInputs = new List<SheetInput>();
        private List<SheetInput> _sheetInputsCollection = new List<SheetInput>();
        private DataInput _dataInput;
        private string _selectedSheetName = string.Empty;

        public ExcelVisualiser(IOrchestratorService orchestratorService, OrientationTemplate orientationTemplate, DataSet excelData, DataInput dataInput)
        {
            _orchestratorService = orchestratorService;
            _orientationTemplate = orientationTemplate;
            _dataInput = dataInput;

            _dataSet = excelData ?? new DataSet(); // Handle potential null dataset

            InitializeComponent();

            // Populate SheetComboBox with sheet names from the DataSet
            foreach (DataTable table in _dataSet.Tables)
            {
                SheetComboBox.Items.Add(table.TableName);
            }
        }

        private void SheetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SheetGridView.DataBindings.Clear();
            _selectedSheetName = SheetComboBox.SelectedItem.ToString();

            var selectedSheetInput = _sheetInputs.Find(x => x.SheetName == _selectedSheetName);

            if (selectedSheetInput != null)
            {
                PopulateSheetInputFields(selectedSheetInput);
            }
            else
            {
                ResetSheetInputFields();
            }

            // Bind the selected DataTable to the GridView
            SheetGridView.DataSource = _dataSet.Tables[_selectedSheetName];
        }

        private void PopulateSheetInputFields(SheetInput sheetInput)
        {
            CollectSheetCheckBox.Checked = sheetInput.CollectSheet;
            StartRowTextBox.Text = sheetInput.StartRow.ToString();
            EndRowTextBox.Text = sheetInput.EndRow.ToString();
            StartColumnTextBox.Text = sheetInput.StartColumn.ToString();
            EndColumnTextBox.Text = sheetInput.EndColumn.ToString();
        }

        private void ResetSheetInputFields()
        {
            CollectSheetCheckBox.Checked = false;
            StartRowTextBox.Clear();
            EndRowTextBox.Clear();
            StartColumnTextBox.Clear();
            EndColumnTextBox.Clear();
        }

        private void FormatBtn_Click(object sender, EventArgs e)
        {
            var selectedSheetInput = _sheetInputs.Find(x => x.SheetName == _selectedSheetName);

            // Parse and set the input values for sheet formatting
            int startRow = ParseTextBoxValue(StartRowTextBox.Text);
            int endRow = ParseTextBoxValue(EndRowTextBox.Text);
            int startColumn = ParseTextBoxValue(StartColumnTextBox.Text);
            int endColumn = ParseTextBoxValue(EndColumnTextBox.Text);

            if (selectedSheetInput == null)
            {
                selectedSheetInput = new SheetInput(_selectedSheetName, IncludesHeaderCheckBox.Checked, startRow, endRow, startColumn, endColumn)
                {
                    CollectSheet = CollectSheetCheckBox.Checked
                };
                _sheetInputs.Add(selectedSheetInput);
            }
            else
            {
                // Update existing sheet input
                selectedSheetInput.CollectSheet = CollectSheetCheckBox.Checked;
                selectedSheetInput.StartRow = startRow;
                selectedSheetInput.EndRow = endRow;
                selectedSheetInput.StartColumn = startColumn;
                selectedSheetInput.EndColumn = endColumn;
            }

            // Copy and format the table
            selectedSheetInput.FormattedTable = _dataSet.Tables[_selectedSheetName].Copy();
            _orchestratorService.MockRun(selectedSheetInput);

            // Bind the formatted table to the GridView
            SheetGridView.DataSource = selectedSheetInput.FormattedTable;
        }

        // Helper method to parse TextBox values to integers safely
        private int ParseTextBoxValue(string text)
        {
            return int.TryParse(text.Trim(), out int result) ? result : 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var selectedSheetInput = _sheetInputs.Find(x => x.SheetName == _selectedSheetName);

            if (selectedSheetInput != null && !_sheetInputsCollection.Contains(selectedSheetInput))
            {
                _sheetInputsCollection.Add(selectedSheetInput);
                SheetCollectionListBox.Items.Add(selectedSheetInput.SheetName);
            }
        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            // Assign the sheet input collection to DataInput
            _dataInput.Sheets = _sheetInputsCollection;

            // Log the sheet names to DataInput
            foreach (DataTable dt in _dataSet.Tables)
            {
                _dataInput.SheetNameLog.Add(dt.TableName);
            }

            // Add the input data to the orientation template
            _orientationTemplate.DataInputs.Add(_dataInput);

            // Close the form
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}