using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPaintWinforms
{
    public partial class CreateTemplateForm : Form
    {
        public CreateTemplateForm()
        {
            InitializeComponent();
        }

        private void GetInputFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFileDialogue = new OpenFileDialog();
            InputFileDirectoryTextBox.Text = inputFileDialogue.FileName;

        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
           // DataPaintLibrary.Services.Classes.DataExtraction(InputFileDirectoryTextBox.Text);
        }
    }
}
