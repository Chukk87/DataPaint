using DataPaintLibrary.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace DataPaintDesktop
{
    public partial class NewOwnerGroupForm : Form
    {
        private readonly ILoggerService _loggerService;
        private readonly ISqlService _sqlService;

        public NewOwnerGroupForm(ILoggerService loggerService, ISqlService sqlService)
        {
            _loggerService = loggerService;
            _sqlService = sqlService;

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
                // Create the owner group asynchronously
                await _sqlService.CreateOwnerGroup(GroupNameTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text);

                // Notify the user of success
                MessageBox.Show("Owner group created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the fields or close the form
                this.Close();
            }
            catch (Exception ex)
            {
                // Log the exception and notify the user
                _loggerService.RecordException(ex, nameof(CreateNewOwnerGroupBtn_Click));
                MessageBox.Show("An error occurred while creating the owner group. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
