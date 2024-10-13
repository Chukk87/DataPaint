namespace DataPaintDesktop
{
    partial class ManageGroupOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroupOwner));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            OwnerGroupListBox = new System.Windows.Forms.ListBox();
            GroupNameTextBox = new System.Windows.Forms.TextBox();
            EmailTextBox = new System.Windows.Forms.TextBox();
            PhoneTextBox = new System.Windows.Forms.TextBox();
            GroupOwnerPanel = new System.Windows.Forms.Panel();
            TopPanel = new System.Windows.Forms.Panel();
            FormNameLabel = new System.Windows.Forms.Label();
            FormIcon = new System.Windows.Forms.PictureBox();
            TitlePanel = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            GroupVisualiserPanel = new System.Windows.Forms.Panel();
            NewGroupOwner = new System.Windows.Forms.PictureBox();
            GroupOwnerPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FormIcon).BeginInit();
            TitlePanel.SuspendLayout();
            GroupVisualiserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NewGroupOwner).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label1.Location = new System.Drawing.Point(7, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Group Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label2.Location = new System.Drawing.Point(7, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Contact Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label3.Location = new System.Drawing.Point(7, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // OwnerGroupListBox
            // 
            OwnerGroupListBox.BackColor = System.Drawing.Color.FromArgb(56, 56, 56);
            OwnerGroupListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            OwnerGroupListBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            OwnerGroupListBox.FormattingEnabled = true;
            OwnerGroupListBox.ItemHeight = 15;
            OwnerGroupListBox.Location = new System.Drawing.Point(0, 0);
            OwnerGroupListBox.Name = "OwnerGroupListBox";
            OwnerGroupListBox.Size = new System.Drawing.Size(300, 204);
            OwnerGroupListBox.TabIndex = 3;
            OwnerGroupListBox.SelectedIndexChanged += OwnerGroupListBox_SelectedIndexChanged;
            // 
            // GroupNameTextBox
            // 
            GroupNameTextBox.Location = new System.Drawing.Point(7, 29);
            GroupNameTextBox.Name = "GroupNameTextBox";
            GroupNameTextBox.Size = new System.Drawing.Size(253, 23);
            GroupNameTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new System.Drawing.Point(7, 73);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new System.Drawing.Size(253, 23);
            EmailTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new System.Drawing.Point(7, 121);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new System.Drawing.Size(253, 23);
            PhoneTextBox.TabIndex = 6;
            // 
            // GroupOwnerPanel
            // 
            GroupOwnerPanel.Controls.Add(OwnerGroupListBox);
            GroupOwnerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            GroupOwnerPanel.Location = new System.Drawing.Point(0, 80);
            GroupOwnerPanel.Name = "GroupOwnerPanel";
            GroupOwnerPanel.Size = new System.Drawing.Size(300, 204);
            GroupOwnerPanel.TabIndex = 11;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(FormNameLabel);
            TopPanel.Controls.Add(FormIcon);
            TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopPanel.Location = new System.Drawing.Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new System.Drawing.Size(582, 52);
            TopPanel.TabIndex = 13;
            // 
            // FormNameLabel
            // 
            FormNameLabel.AutoSize = true;
            FormNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormNameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            FormNameLabel.Location = new System.Drawing.Point(56, 11);
            FormNameLabel.Name = "FormNameLabel";
            FormNameLabel.Size = new System.Drawing.Size(155, 30);
            FormNameLabel.TabIndex = 13;
            FormNameLabel.Text = "Owner Groups";
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
            // TitlePanel
            // 
            TitlePanel.Controls.Add(label5);
            TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            TitlePanel.Location = new System.Drawing.Point(0, 52);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new System.Drawing.Size(582, 28);
            TitlePanel.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label5.Location = new System.Drawing.Point(4, 7);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Owner Groups";
            // 
            // GroupVisualiserPanel
            // 
            GroupVisualiserPanel.Controls.Add(PhoneTextBox);
            GroupVisualiserPanel.Controls.Add(label1);
            GroupVisualiserPanel.Controls.Add(label2);
            GroupVisualiserPanel.Controls.Add(label3);
            GroupVisualiserPanel.Controls.Add(GroupNameTextBox);
            GroupVisualiserPanel.Controls.Add(EmailTextBox);
            GroupVisualiserPanel.Location = new System.Drawing.Point(306, 86);
            GroupVisualiserPanel.Name = "GroupVisualiserPanel";
            GroupVisualiserPanel.Size = new System.Drawing.Size(273, 155);
            GroupVisualiserPanel.TabIndex = 16;
            // 
            // NewGroupOwner
            // 
            NewGroupOwner.Image = (System.Drawing.Image)resources.GetObject("NewGroupOwner.Image");
            NewGroupOwner.Location = new System.Drawing.Point(545, 247);
            NewGroupOwner.Name = "NewGroupOwner";
            NewGroupOwner.Size = new System.Drawing.Size(34, 34);
            NewGroupOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            NewGroupOwner.TabIndex = 17;
            NewGroupOwner.TabStop = false;
            NewGroupOwner.Click += NewGroupOwner_Click;
            // 
            // ManageGroupOwner
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(582, 284);
            Controls.Add(NewGroupOwner);
            Controls.Add(GroupVisualiserPanel);
            Controls.Add(GroupOwnerPanel);
            Controls.Add(TitlePanel);
            Controls.Add(TopPanel);
            Name = "ManageGroupOwner";
            Text = "ManageGroupOwner";
            GroupOwnerPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FormIcon).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            GroupVisualiserPanel.ResumeLayout(false);
            GroupVisualiserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NewGroupOwner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox OwnerGroupListBox;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Panel GroupOwnerPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.PictureBox FormIcon;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel GroupVisualiserPanel;
        private System.Windows.Forms.PictureBox NewGroupOwner;
    }
}