namespace DataPaintDesktop.Forms.OrientationForms
{
    partial class ExcelExtractionForm
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
            label6 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            FindDirectoryBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label6.Location = new System.Drawing.Point(9, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Directory";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(70, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(239, 23);
            textBox2.TabIndex = 14;
            // 
            // FindDirectoryBtn
            // 
            FindDirectoryBtn.Location = new System.Drawing.Point(288, 41);
            FindDirectoryBtn.Name = "FindDirectoryBtn";
            FindDirectoryBtn.Size = new System.Drawing.Size(21, 23);
            FindDirectoryBtn.TabIndex = 15;
            FindDirectoryBtn.Text = "button2";
            FindDirectoryBtn.UseVisualStyleBackColor = true;
            FindDirectoryBtn.Click += FindDirectoryBtn_Click;
            // 
            // ExcelExtractionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(572, 200);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(FindDirectoryBtn);
            Name = "ExcelExtractionForm";
            Text = "ExcelExtractionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button FindDirectoryBtn;
    }
}