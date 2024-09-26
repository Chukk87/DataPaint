using System;
using System.Windows.Forms;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintDesktop
{
    public partial class Form1 : Form
    {
        private readonly IDataExtractionService _dataExtraction;

        public Form1(IDataExtractionService dataExtraction)
        {
            InitializeComponent();
            _dataExtraction = dataExtraction;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
