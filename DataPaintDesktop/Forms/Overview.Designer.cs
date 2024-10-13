namespace DataPaintDesktop.Forms
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            listView1 = new System.Windows.Forms.ListView();
            Orientation = new System.Windows.Forms.ColumnHeader();
            Group = new System.Windows.Forms.ColumnHeader();
            LastRun = new System.Windows.Forms.ColumnHeader();
            Scheduled = new System.Windows.Forms.ColumnHeader();
            checkBox1 = new System.Windows.Forms.CheckBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            TopPanel = new System.Windows.Forms.Panel();
            FormNameLabel = new System.Windows.Forms.Label();
            FormIcon = new System.Windows.Forms.PictureBox();
            FormControlPanel = new System.Windows.Forms.Panel();
            TitlePanel = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            DataGroupSummaryPanel = new System.Windows.Forms.Panel();
            SeperatorPanel = new System.Windows.Forms.Panel();
            SchedulerPanel = new System.Windows.Forms.Panel();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FormIcon).BeginInit();
            FormControlPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            DataGroupSummaryPanel.SuspendLayout();
            SchedulerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.FromArgb(56, 56, 56);
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Orientation, Group, LastRun, Scheduled });
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(398, 437);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Orientation
            // 
            Orientation.Text = "Orientation";
            // 
            // Group
            // 
            Group.Text = "Group";
            // 
            // LastRun
            // 
            LastRun.Text = "Last Run";
            // 
            // Scheduled
            // 
            Scheduled.Text = "Scheduled";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            checkBox1.Location = new System.Drawing.Point(359, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(68, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "View All";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.FromArgb(56, 56, 56);
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.ForeColor = System.Drawing.SystemColors.Menu;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(110, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(243, 23);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label1.Location = new System.Drawing.Point(4, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Your Data Groups";
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(FormNameLabel);
            TopPanel.Controls.Add(FormIcon);
            TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopPanel.Location = new System.Drawing.Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new System.Drawing.Size(947, 52);
            TopPanel.TabIndex = 12;
            // 
            // FormNameLabel
            // 
            FormNameLabel.AutoSize = true;
            FormNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormNameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            FormNameLabel.Location = new System.Drawing.Point(56, 11);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new System.Drawing.Size(105, 30);
            FormNameLabel.TabIndex = 13;
            FormNameLabel.Text = "Overview";
            // 
            // FormIcon
            // 
            FormIcon.Image = (System.Drawing.Image)resources.GetObject("FormIcon.Image");
            FormIcon.Location = new System.Drawing.Point(2, 3);
            FormIcon.Name = "FormIcon";
            FormIcon.Size = new System.Drawing.Size(47, 47);
            FormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            FormIcon.TabIndex = 13;
            FormIcon.TabStop = false;
            // 
            // FormControlPanel
            // 
            FormControlPanel.Controls.Add(comboBox1);
            FormControlPanel.Controls.Add(label1);
            FormControlPanel.Controls.Add(checkBox1);
            FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            FormControlPanel.Location = new System.Drawing.Point(0, 52);
            FormControlPanel.Name = "FormControlPanel";
            FormControlPanel.Size = new System.Drawing.Size(947, 31);
            FormControlPanel.TabIndex = 13;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(label3);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            TitlePanel.Location = new System.Drawing.Point(0, 83);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new System.Drawing.Size(947, 28);
            TitlePanel.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label3.Location = new System.Drawing.Point(426, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 15);
            label3.TabIndex = 10;
            label3.Text = "Scheduler View";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label2.Location = new System.Drawing.Point(4, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 15);
            label2.TabIndex = 9;
            label2.Text = "Your Data Group Summary";
            // 
            // DataGroupSummaryPanel
            // 
            DataGroupSummaryPanel.Controls.Add(listView1);
            DataGroupSummaryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            DataGroupSummaryPanel.Location = new System.Drawing.Point(0, 111);
            DataGroupSummaryPanel.Name = "DataGroupSummaryPanel";
            DataGroupSummaryPanel.Size = new System.Drawing.Size(398, 437);
            DataGroupSummaryPanel.TabIndex = 15;
            // 
            // SeperatorPanel
            // 
            SeperatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            SeperatorPanel.Location = new System.Drawing.Point(398, 111);
            SeperatorPanel.Name = "SeperatorPanel";
            SeperatorPanel.Size = new System.Drawing.Size(28, 437);
            SeperatorPanel.TabIndex = 16;
            // 
            // SchedulerPanel
            // 
            SchedulerPanel.Controls.Add(listView2);
            SchedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SchedulerPanel.Location = new System.Drawing.Point(426, 111);
            SchedulerPanel.Name = "SchedulerPanel";
            SchedulerPanel.Size = new System.Drawing.Size(521, 437);
            SchedulerPanel.TabIndex = 17;
            // 
            // listView2
            // 
            listView2.BackColor = System.Drawing.Color.FromArgb(56, 56, 56);
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            listView2.Location = new System.Drawing.Point(0, 0);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(521, 437);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Orientation";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Group";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last Run";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Scheduled";
            // 
            // Overview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(947, 548);
            Controls.Add(SchedulerPanel);
            Controls.Add(SeperatorPanel);
            Controls.Add(DataGroupSummaryPanel);
            Controls.Add(TitlePanel);
            Controls.Add(FormControlPanel);
            Controls.Add(TopPanel);
            Name = "Overview";
            Text = "Overview";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FormIcon).EndInit();
            FormControlPanel.ResumeLayout(false);
            FormControlPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            DataGroupSummaryPanel.ResumeLayout(false);
            SchedulerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Orientation;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader LastRun;
        private System.Windows.Forms.ColumnHeader Scheduled;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox FormIcon;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DataGroupSummaryPanel;
        private System.Windows.Forms.Panel SeperatorPanel;
        private System.Windows.Forms.Panel SchedulerPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}