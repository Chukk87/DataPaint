using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Enums;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class ManageSecurityGroups : Form
    {
        private readonly IAppCollectionService _appCollectionService;
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;
        private readonly ISecurityGroupService _securityGroupService;

        private List<User> _users;
        private List<SecurityGroup> _securityGroups;

        private SecurityGroup _selectedSecurityGroup;

        public ManageSecurityGroups(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService,
                                    ISecurityGroupService securityGroupService)
        {
            _appCollectionService = appCollectionService;
            _loggerService = loggerService;
            _sqlService = sqlService;
            _securityGroupService = securityGroupService;

            InitializeComponent();
            SetupEventHandlers();
            this.Load += ManageSecurityGroups_Load;
        }

        private void SetupEventHandlers()
        {
            NoSecurityRadio.CheckedChanged += SecurityRadioButtons_CheckedChanged;
            GroupUserRunSecurityRadio.CheckedChanged += SecurityRadioButtons_CheckedChanged;

            NoneRadio.CheckedChanged += AuthorisationRadioButtons_CheckedChanged;
            GroupAdminAndUserRadio.CheckedChanged += AuthorisationRadioButtons_CheckedChanged;
            GroupAdminRadio.CheckedChanged += AuthorisationRadioButtons_CheckedChanged;
            AnyRadio.CheckedChanged += AuthorisationRadioButtons_CheckedChanged;

            VisibleToAllCheckBox.CheckedChanged += VisibleToAllCheckBox_CheckedChanged;
        }

        private async void ManageSecurityGroups_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync();
                InitializeUIComponents();
                UpdateSecurityGroupUI(_securityGroups.FirstOrDefault());
            }
            catch (Exception ex)
            {
                _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        private async Task LoadDataAsync()
        {
            _users = await _appCollectionService.GetAllUsers();
            _securityGroups = await _appCollectionService.GetSecurityGroups();
        }

        private void InitializeUIComponents()
        {
            SecurityGroupCombobox.DataSource = _securityGroups;
            SecurityGroupCombobox.DisplayMember = "GroupName";

            AdminUserCombobox.DataSource = _users;
            AdminUserCombobox.DisplayMember = "FullName";

            UserCombobox.DataSource = _users;
            UserCombobox.DisplayMember = "FullName";
        }

        private void UpdateSecurityGroupUI(SecurityGroup securityGroup)
        {
            if (securityGroup == null)
            {
                ResetUI();
                return;
            }

            _selectedSecurityGroup = securityGroup;

            VisibleToAllCheckBox.Checked = securityGroup.VisibleToAll;
            SetSecurityTypeRadio(securityGroup.SecurityType);
            SetAuthorisationTypeRadio(securityGroup.AuthorisationType);

            UpdateAdminList(securityGroup);
            UpdateUserList(securityGroup);
        }

        private void ResetUI()
        {
            VisibleToAllCheckBox.Checked = false;
            SetSecurityTypeRadio(SecurityType.None);
            SetAuthorisationTypeRadio(AuthorisationType.None);
            AdminListBox.DataSource = null;
            UserListBox.DataSource = null;
        }

        private void SetSecurityTypeRadio(SecurityType securityType)
        {
            NoSecurityRadio.Checked = securityType == SecurityType.None;
            GroupUserRunSecurityRadio.Checked = securityType == SecurityType.GroupOnly;
        }

        private void SetAuthorisationTypeRadio(AuthorisationType authorisationType)
        {
            NoneRadio.Checked = authorisationType == AuthorisationType.None;
            GroupAdminAndUserRadio.Checked = authorisationType == AuthorisationType.AdminAndUser;
            GroupAdminRadio.Checked = authorisationType == AuthorisationType.Admin;
            AnyRadio.Checked = authorisationType == AuthorisationType.Any;
        }

        private void UpdateAdminList(SecurityGroup securityGroup)
        {
            AdminListBox.DataSource = _securityGroupService.GetAdminUsersForSecurityGroup(securityGroup, _users);
            AdminListBox.DisplayMember = "FullName";
        }

        private void UpdateUserList(SecurityGroup securityGroup)
        {
            UserListBox.DataSource = _securityGroupService.GetUsersForSecurityGroup(securityGroup, _users);
            UserListBox.DisplayMember = "FullName";
        }

        private void SecurityGroupCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = SecurityGroupCombobox.SelectedItem as SecurityGroup;
            if (selectedGroup != null)
            {
                UpdateSecurityGroupUI(selectedGroup);
            }
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            var selectedUser = AdminUserCombobox.SelectedItem as User;

            if (_selectedSecurityGroup != null && selectedUser != null && !_selectedSecurityGroup.Admins.Contains(selectedUser.Id))
            {
                _selectedSecurityGroup.Admins.Add(selectedUser.Id);
                UpdateAdminList(_selectedSecurityGroup);
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var selectedUser = UserCombobox.SelectedItem as User;

            if (_selectedSecurityGroup != null && selectedUser != null && !_selectedSecurityGroup.Users.Contains(selectedUser.Id))
            {
                _selectedSecurityGroup.Users.Add(selectedUser.Id);
                UpdateUserList(_selectedSecurityGroup);
            }
        }

        private void CreateSecurityGroupBtn_Click(object sender, EventArgs e)
        {
            var newGroupName = NewSecurityGroupTextbox.Text;
            if (!string.IsNullOrEmpty(newGroupName) && !_securityGroups.Any(sg => sg.GroupName == newGroupName))
            {
                _sqlService.CreateSecurityGroup(newGroupName);
                ManageSecurityGroups_Load(sender, e); // Refresh the form after creating the group
            }
        }

        private async void SaveChnagesBtn_Click(object sender, EventArgs e)
        {
            if (_selectedSecurityGroup == null)
            {
                MessageBox.Show("Please select a security group.");
                return;
            }

            try
            {
                await _sqlService.UpdateSecurityGroup(_selectedSecurityGroup);  // Update the security group in the database
                MessageBox.Show("Security group changes saved successfully.");
            }
            catch (Exception ex)
            {
                _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
                MessageBox.Show("Failed to save changes. Check the logs for more information.");
            }
        }

        private void SecurityRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedSecurityGroup == null) return;

            if (NoSecurityRadio.Checked)
            {
                _selectedSecurityGroup.SecurityType = SecurityType.None;
            }
            else if (GroupUserRunSecurityRadio.Checked)
            {
                _selectedSecurityGroup.SecurityType = SecurityType.GroupOnly;
            }
        }

        private void AuthorisationRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedSecurityGroup == null) return;

            if (NoneRadio.Checked)
            {
                _selectedSecurityGroup.AuthorisationType = AuthorisationType.None;
            }
            else if (GroupAdminAndUserRadio.Checked)
            {
                _selectedSecurityGroup.AuthorisationType = AuthorisationType.AdminAndUser;
            }
            else if (GroupAdminRadio.Checked)
            {
                _selectedSecurityGroup.AuthorisationType = AuthorisationType.Admin;
            }
            else if (AnyRadio.Checked)
            {
                _selectedSecurityGroup.AuthorisationType = AuthorisationType.Any;
            }
        }

        private void VisibleToAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedSecurityGroup != null)
            {
                _selectedSecurityGroup.VisibleToAll = VisibleToAllCheckBox.Checked;
            }
        }
    }
}