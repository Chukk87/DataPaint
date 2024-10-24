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
using DataPaintDesktop.Forms.OrientationForms;

namespace DataPaintDesktop
{
    public partial class OrientationSetup : Form
    {
        private readonly IDataExtractionService _extractionService;
        private readonly ISqlService _sqlService;
        private readonly IClassBuilderService _classBuilderService;
        private readonly IOrchestratorService _orchestratorService;
        private readonly Home _homeForm;

        private OrientationTemplate _orientationTemplate;
        List<OwnerGroup> _ownersGroup;
        List<SecurityGroup> _securityGroups;

        public OrientationSetup(IDataExtractionService dataExtractionService, ISqlService sqlService, IOrchestratorService orchestratorService,
                                IClassBuilderService classBuilderService, Home homeForm)
        {
            _extractionService = dataExtractionService;
            _sqlService = sqlService;
            _orchestratorService = orchestratorService;
            _classBuilderService = classBuilderService;
            _homeForm = homeForm;

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

        private void InputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var inputType = (ExtractionType)InputTypeComboBox.SelectedItem;

            switch (inputType)
            {
                case ExtractionType.Api:
                    break;

                case ExtractionType.Excel:
                    LoadFormIntoExtractionPanel(new ExcelExtractionForm(this, _homeForm, _orchestratorService, _extractionService, _orientationTemplate));
                    break;

                case ExtractionType.TextTab:
                    break;

                case ExtractionType.TextDelimiter:
                    break;

                case ExtractionType.CSV:
                    break;

                default:
                    MessageBox.Show("Please select a valid extraction type");
                    break;
            }
        }

        internal void LoadFormIntoExtractionPanel(Form form)
        {
            ExtractionPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            ExtractionPanel.Controls.Add(form);

            form.Show();
        }
    }
}
