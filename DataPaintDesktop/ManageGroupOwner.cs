using DataPaintLibrary.Classes;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class ManageGroupOwner : Form
    {
        private readonly IAppCollectionService _appCollectionService;
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;
        private List<OwnerGroup> _ownerGroups;

        public ManageGroupOwner(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService)
        {
            _appCollectionService = appCollectionService;
            _loggerService = loggerService;
            _sqlService = sqlService;

            InitializeComponent();

            this.Load += ManageGroupOwner_Load;
            OwnerGroupListBox.SelectedIndexChanged += OwnerGroupListBox_SelectedIndexChanged;
        }

        private async void ManageGroupOwner_Load(object sender, EventArgs e)
        {
            try
            {
                _ownerGroups = await _appCollectionService.GetAllOwnerGroups();

                OwnerGroupListBox.DataSource = _ownerGroups;
                OwnerGroupListBox.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void OwnerGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OwnerGroupListBox.SelectedItem is OwnerGroup selectedOwnerGroup)
            {
                GroupNameTextBox.Text = selectedOwnerGroup.Name;
                EmailTextBox.Text = selectedOwnerGroup.ContactEmail;
                PhoneTextBox.Text = selectedOwnerGroup.PhoneNumber;
            }
        }

        private void CreateNewOwnerGroupBtn_Click(object sender, EventArgs e)
        {
            NewOwnerGroupForm newOwnerGroupForm = new NewOwnerGroupForm(_loggerService, _sqlService);
            newOwnerGroupForm.ShowDialog();

            ManageGroupOwner_Load(sender, e);
        }
    }
}
