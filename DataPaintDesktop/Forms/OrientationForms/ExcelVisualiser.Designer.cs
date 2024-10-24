namespace DataPaintDesktop
{
    partial class ExcelVisualiser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SheetComboBox = new System.Windows.Forms.ComboBox();
            SheetGridView = new System.Windows.Forms.DataGridView();
            CollectSheetCheckBox = new System.Windows.Forms.CheckBox();
            IncludesHeaderCheckBox = new System.Windows.Forms.CheckBox();
            EndColumnTextBox = new System.Windows.Forms.TextBox();
            StartColumnTextBox = new System.Windows.Forms.TextBox();
            EndRowTextBox = new System.Windows.Forms.TextBox();
            StartRowTextBox = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            FormatBtn = new System.Windows.Forms.Button();
            SaveBtn = new System.Windows.Forms.Button();
            SheetCollectionListBox = new System.Windows.Forms.ListBox();
            CompleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)SheetGridView).BeginInit();
            SuspendLayout();
            // 
            // SheetComboBox
            // 
            SheetComboBox.FormattingEnabled = true;
            SheetComboBox.Location = new System.Drawing.Point(12, 12);
            SheetComboBox.Name = "SheetComboBox";
            SheetComboBox.Size = new System.Drawing.Size(121, 23);
            SheetComboBox.TabIndex = 0;
            SheetComboBox.SelectedIndexChanged += SheetComboBox_SelectedIndexChanged;
            // 
            // SheetGridView
            // 
            SheetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SheetGridView.Location = new System.Drawing.Point(12, 41);
            SheetGridView.Name = "SheetGridView";
            SheetGridView.Size = new System.Drawing.Size(1046, 397);
            SheetGridView.TabIndex = 1;
            // 
            // CollectSheetCheckBox
            // 
            CollectSheetCheckBox.AutoSize = true;
            CollectSheetCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            CollectSheetCheckBox.Location = new System.Drawing.Point(139, 16);
            CollectSheetCheckBox.Name = "CollectSheetCheckBox";
            CollectSheetCheckBox.Size = new System.Drawing.Size(94, 19);
            CollectSheetCheckBox.TabIndex = 2;
            CollectSheetCheckBox.Text = "Collect sheet";
            CollectSheetCheckBox.UseVisualStyleBackColor = true;
            // 
            // IncludesHeaderCheckBox
            // 
            IncludesHeaderCheckBox.AutoSize = true;
            IncludesHeaderCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            IncludesHeaderCheckBox.Location = new System.Drawing.Point(239, 16);
            IncludesHeaderCheckBox.Name = "IncludesHeaderCheckBox";
            IncludesHeaderCheckBox.Size = new System.Drawing.Size(111, 19);
            IncludesHeaderCheckBox.TabIndex = 3;
            IncludesHeaderCheckBox.Text = "Includes Header";
            IncludesHeaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndColumnTextBox
            // 
            EndColumnTextBox.Location = new System.Drawing.Point(794, 12);
            EndColumnTextBox.Name = "EndColumnTextBox";
            EndColumnTextBox.Size = new System.Drawing.Size(44, 23);
            EndColumnTextBox.TabIndex = 32;
            // 
            // StartColumnTextBox
            // 
            StartColumnTextBox.Location = new System.Drawing.Point(660, 12);
            StartColumnTextBox.Name = "StartColumnTextBox";
            StartColumnTextBox.Size = new System.Drawing.Size(44, 23);
            StartColumnTextBox.TabIndex = 31;
            // 
            // EndRowTextBox
            // 
            EndRowTextBox.Location = new System.Drawing.Point(527, 12);
            EndRowTextBox.Name = "EndRowTextBox";
            EndRowTextBox.Size = new System.Drawing.Size(44, 23);
            EndRowTextBox.TabIndex = 30;
            // 
            // StartRowTextBox
            // 
            StartRowTextBox.Location = new System.Drawing.Point(423, 12);
            StartRowTextBox.Name = "StartRowTextBox";
            StartRowTextBox.Size = new System.Drawing.Size(39, 23);
            StartRowTextBox.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(715, 17);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(73, 15);
            label12.TabIndex = 28;
            label12.Text = "End Column";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(577, 15);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(77, 15);
            label11.TabIndex = 27;
            label11.Text = "Start Column";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(468, 17);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(53, 15);
            label10.TabIndex = 26;
            label10.Text = "End Row";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(365, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(57, 15);
            label9.TabIndex = 25;
            label9.Text = "Start Row";
            // 
            // FormatBtn
            // 
            FormatBtn.Location = new System.Drawing.Point(844, 13);
            FormatBtn.Name = "FormatBtn";
            FormatBtn.Size = new System.Drawing.Size(104, 23);
            FormatBtn.TabIndex = 33;
            FormatBtn.Text = "Formatted View";
            FormatBtn.UseVisualStyleBackColor = true;
            FormatBtn.Click += FormatBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new System.Drawing.Point(954, 12);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(104, 23);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save Details";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // SheetCollectionListBox
            // 
            SheetCollectionListBox.FormattingEnabled = true;
            SheetCollectionListBox.ItemHeight = 15;
            SheetCollectionListBox.Location = new System.Drawing.Point(12, 444);
            SheetCollectionListBox.Name = "SheetCollectionListBox";
            SheetCollectionListBox.Size = new System.Drawing.Size(1046, 94);
            SheetCollectionListBox.TabIndex = 36;
            // 
            // CompleteBtn
            // 
            CompleteBtn.Location = new System.Drawing.Point(954, 544);
            CompleteBtn.Name = "CompleteBtn";
            CompleteBtn.Size = new System.Drawing.Size(104, 23);
            CompleteBtn.TabIndex = 37;
            CompleteBtn.Text = "Complete";
            CompleteBtn.UseVisualStyleBackColor = true;
            CompleteBtn.Click += CompleteBtn_Click;
            // 
            // ExcelVisualiser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1068, 573);
            Controls.Add(CompleteBtn);
            Controls.Add(SheetCollectionListBox);
            Controls.Add(SaveBtn);
            Controls.Add(FormatBtn);
            Controls.Add(EndColumnTextBox);
            Controls.Add(StartColumnTextBox);
            Controls.Add(EndRowTextBox);
            Controls.Add(StartRowTextBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(IncludesHeaderCheckBox);
            Controls.Add(CollectSheetCheckBox);
            Controls.Add(SheetGridView);
            Controls.Add(SheetComboBox);
            Name = "ExcelVisualiser";
            Text = "ExcelVisualiser";
            ((System.ComponentModel.ISupportInitialize)SheetGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox SheetComboBox;
        private System.Windows.Forms.DataGridView SheetGridView;
        private System.Windows.Forms.CheckBox CollectSheetCheckBox;
        private System.Windows.Forms.CheckBox IncludesHeaderCheckBox;
        private System.Windows.Forms.TextBox EndColumnTextBox;
        private System.Windows.Forms.TextBox StartColumnTextBox;
        private System.Windows.Forms.TextBox EndRowTextBox;
        private System.Windows.Forms.TextBox StartRowTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FormatBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox SheetCollectionListBox;
        private System.Windows.Forms.Button CompleteBtn;
    }
}