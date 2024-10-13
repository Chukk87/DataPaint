using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Enums;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class OrientationSetup : Form
    {
        private readonly IDataExtractionService _extractionService;
        private readonly ISqlService _sqlService;
        private readonly IClassBuilderService _classBuilderService;
        private readonly IOrchestratorService _orchestratorService;

        private OrientationTemplate _orientationTemplate;
        List<OwnerGroup> _ownersGroup;
        List<SecurityGroup> _securityGroups;

        public OrientationSetup(IDataExtractionService dataExtractionService, ISqlService sqlService, IOrchestratorService orchestratorService,
                                IClassBuilderService classBuilderService)
        {
            _extractionService = dataExtractionService;
            _sqlService = sqlService;
            _orchestratorService = orchestratorService;
            _classBuilderService = classBuilderService;

            InitializeComponent();
        }

        private async void OrientationSetup_Load(object sender, EventArgs e)
        {
            await PopulateSecurityGroups();
            await PopulateGroupOwners();
            PopulateInputType();
        }

        public async Task PopulateSecurityGroups()
        {
            DataTable securityTable = await _sqlService.GetSecurityGroups();
            DataTable usersTable = await _sqlService.GetUserSecurity();

            _securityGroups = _classBuilderService.BuildSecurityGroups(securityTable, usersTable);
            SecurityGroupComboBox.DataSource = _securityGroups;
            SecurityGroupComboBox.DisplayMember = "GroupName";
            SecurityGroupComboBox.ValueMember = "Id";
        }

        private async Task PopulateGroupOwners()
        {
            DataTable ownerGroupsTable = await _sqlService.GetOwnerGroups();

            _ownersGroup = _classBuilderService.BuildOwnerGroups(ownerGroupsTable);
            GroupOwnerComboBox.DataSource = _ownersGroup;
            GroupOwnerComboBox.DisplayMember = "Name";
            GroupOwnerComboBox.ValueMember = "Id";
        }

        private void PopulateInputType()
        {
            InputTypeComboBox.DataSource = Enum.GetValues(typeof(ExtractionType)).Cast<ExtractionType>().ToList();
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

                foreach (var di in _orientationTemplate.DataInputs)
                {
                    InputDataListBox.Items.Add(di.Name);
                }
            }
        }

        private void StartSteps_Click(object sender, EventArgs e)
        {
            _orchestratorService.Run(_orientationTemplate.DataInputs);


        }

        private void CreateBase_Click(object sender, EventArgs e)
        {
            _orientationTemplate = new OrientationTemplate()
            {
                ReportName = ReportNameTextBox.Text
            };

            ReportNameTextBox.Enabled = false;
            SecurityGroupComboBox.Enabled = false;
            CreateBase.Visible = false;
        }
    }
}
