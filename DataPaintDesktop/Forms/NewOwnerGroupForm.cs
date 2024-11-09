using DataPaintLibrary.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class NewOwnerGroupForm : Form
    {
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;
        private readonly Home _homeForm;
        private readonly ManageGroupOwner _manageGroupOwner1Form;

        public NewOwnerGroupForm(ILoggerService loggerService, ISqlService sqlService, Home homeForm, ManageGroupOwner manageGroupOwner)
        {
            _loggerService = loggerService;
            _sqlService = sqlService;
            _homeForm = homeForm;
            _manageGroupOwner1Form = manageGroupOwner;

            InitializeComponent();
        }

        private async void CreateNewOwnerGroupBtn_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(GroupNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await _sqlService.CreateOwnerGroupAsync(GroupNameTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text);

                MessageBox.Show("Owner group created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _manageGroupOwner1Form.ManageGroupOwner_Load(sender, e);
                _homeForm.FooterPanel.Visible = false;

                this.Close();
            }
            catch (Exception ex)
            {
                // Log the exception and notify the user
                _loggerService.RecordException(ex, nameof(CreateNewOwnerGroupBtn_Click));
                MessageBox.Show("An error occurred while creating the owner group. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewOwnerGroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
