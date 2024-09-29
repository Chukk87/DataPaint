using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class ManageSecurityGroups : Form
    {
        private readonly IAppCollectionService _appCollectionService;
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;

        private List<User> _users;
        private List<SecurityGroup> _securityGroups;

        public ManageSecurityGroups(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService)
        {
            _appCollectionService = appCollectionService;
            _loggerService = loggerService;
            _sqlService = sqlService;

            InitializeComponent();

            this.Load += ManageSecurityGroups_Load;
        }

        private async void ManageSecurityGroups_Load(object sender, EventArgs e)
        {
            try
            {
                _users = await _appCollectionService.GetAllUsers();
                _securityGroups = await _appCollectionService.GetSecurityGroups();

                SecurityGroupCombobox.DataSource = _securityGroups;
                SecurityGroupCombobox.DisplayMember = "GroupName";

                AdminUserCombobox.DataSource = _users;
                AdminUserCombobox.DisplayMember = "FullName";

                UserCombobox.DataSource = _users;
                UserCombobox.DisplayMember = "FullName";
            }
            catch (Exception ex)
            {
                _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void SaveChnagesBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateSecurityGroupBtn_Click(object sender, EventArgs e)
        {
            if(!SecurityGroupCombobox.Items.Contains(NewSecurityGroupTextbox.Text))
            {
                _sqlService.CreateSecurityGroup(NewSecurityGroupTextbox.Text);
            }
        }
    }
}
