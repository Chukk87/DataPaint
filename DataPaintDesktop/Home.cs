using System;
using System.Windows.Forms;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintDesktop
{
    public partial class Home : Form
    {
        private readonly IAppCollectionService _appCollectionService;
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;
        private readonly IDataExtractionService _extractionService;
        private readonly IOrchestratorService _orchestratorService;
        private readonly ISecurityGroupService _securityGroupService;
        private readonly IClassBuilderService _classBuilderService;

        public Home(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService, IDataExtractionService extractionService,
                    IOrchestratorService orchestratorService, ISecurityGroupService securityGroupService, IClassBuilderService classBuilderService)
        {
            InitializeComponent();

            _appCollectionService = appCollectionService;
            _loggerService = loggerService;
            _sqlService = sqlService;
            _extractionService = extractionService;
            _orchestratorService = orchestratorService;
            _securityGroupService = securityGroupService;
            _classBuilderService = classBuilderService;
        }

        private void ManageGroupOwnerBtn_Click(object sender, EventArgs e)
        {
            var manageGroupOwner = new ManageGroupOwner(_appCollectionService, _loggerService, _sqlService);
            manageGroupOwner.Show();
        }

        private void SetupOrientationBtn_Click(object sender, EventArgs e)
        {
            var orientationSetup = new OrientationSetup(_extractionService, _sqlService, _orchestratorService, _classBuilderService);
            orientationSetup.Show();
        }

        private void ManageSecurityGroupsBtn_Click(object sender, EventArgs e)
        {
            var manageSecurityGroups = new ManageSecurityGroups(_appCollectionService, _loggerService, _sqlService, _securityGroupService);
            manageSecurityGroups.Show();
        }
    }
}
