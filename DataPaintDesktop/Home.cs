using System;
using System.Windows.Forms;
using DataPaintDesktop.Forms;
using DataPaintDesktop.Rendering;
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

            var overViewForm = new Overview();
            LoadFormIntoPrimaryPanel(overViewForm);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MainMenu.Renderer = new ToolStripRender();
        }

        private void HomeStripButton_Click(object sender, EventArgs e)
        {
            var overview = new Overview();
            LoadFormIntoPrimaryPanel(overview);
        }

        private void GroupOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageGroupOwner = new ManageGroupOwner(_appCollectionService, _loggerService, _sqlService, this);
            LoadFormIntoPrimaryPanel(manageGroupOwner);
        }

        private void SecurityGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageSecurityGroups = new ManageSecurityGroups(_appCollectionService, _loggerService, _sqlService, _securityGroupService);
            LoadFormIntoPrimaryPanel(manageSecurityGroups);
        }

        private void NewOrientationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Data Paint - New Orientation";

            var orientationSetup = new OrientationSetup(_extractionService, _sqlService, _orchestratorService, _classBuilderService, this);
            LoadFormIntoPrimaryPanel(orientationSetup);
        }

        internal void LoadFormIntoPrimaryPanel(Form form)
        {
            PrimaryPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            PrimaryPanel.Controls.Add(form);

            SecondaryPanel.Visible = false;
            form.Show();
        }

        internal void LoadFormIntoSecondaryPanel(Form form)
        {
            SecondaryPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            SecondaryPanel.Controls.Add(form);

            PrimaryPanel.Visible = false;
            form.Show();
        }

        internal void LoadFormIntoFooterPanel(Form form)
        {
            FooterPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            FooterPanel.Controls.Add(form);

            form.Show();
        }

        private void CollapeTools_Click(object sender, EventArgs e)
        {
            ToolPanel.Visible = false;
        }

        private void ToolStripAuthorisationButton_Click(object sender, EventArgs e)
        {
            ToolPanel.Visible = true;
            ToolTitleLabel.Text = "Authorisation";
        }

        private void ExportStripButton_Click(object sender, EventArgs e)
        {
            ToolPanel.Visible = true;
            ToolTitleLabel.Text = "Export";
        }

        private void CollapseFooter_Click(object sender, EventArgs e)
        {
            FooterPanel.Visible = false;
        }
    }
}