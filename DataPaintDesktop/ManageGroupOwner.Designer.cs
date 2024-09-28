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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            OwnerGroupListBox = new System.Windows.Forms.ListBox();
            GroupNameTextBox = new System.Windows.Forms.TextBox();
            EmailTextBox = new System.Windows.Forms.TextBox();
            PhoneTextBox = new System.Windows.Forms.TextBox();
            CreateNewOwnerGroupBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(164, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Group Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(164, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Contact Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(164, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // OwnerGroupListBox
            // 
            OwnerGroupListBox.FormattingEnabled = true;
            OwnerGroupListBox.ItemHeight = 15;
            OwnerGroupListBox.Location = new System.Drawing.Point(12, 12);
            OwnerGroupListBox.Name = "OwnerGroupListBox";
            OwnerGroupListBox.Size = new System.Drawing.Size(146, 424);
            OwnerGroupListBox.TabIndex = 3;
            OwnerGroupListBox.SelectedIndexChanged += OwnerGroupListBox_SelectedIndexChanged;
            // 
            // GroupNameTextBox
            // 
            GroupNameTextBox.Location = new System.Drawing.Point(261, 10);
            GroupNameTextBox.Name = "GroupNameTextBox";
            GroupNameTextBox.Size = new System.Drawing.Size(253, 23);
            GroupNameTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new System.Drawing.Point(261, 34);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new System.Drawing.Size(253, 23);
            EmailTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new System.Drawing.Point(261, 58);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new System.Drawing.Size(253, 23);
            PhoneTextBox.TabIndex = 6;
            // 
            // CreateNewOwnerGroupBtn
            // 
            CreateNewOwnerGroupBtn.Location = new System.Drawing.Point(358, 409);
            CreateNewOwnerGroupBtn.Name = "CreateNewOwnerGroupBtn";
            CreateNewOwnerGroupBtn.Size = new System.Drawing.Size(154, 23);
            CreateNewOwnerGroupBtn.TabIndex = 7;
            CreateNewOwnerGroupBtn.Text = "Create New Owner Group";
            CreateNewOwnerGroupBtn.UseVisualStyleBackColor = true;
            CreateNewOwnerGroupBtn.Click += CreateNewOwnerGroupBtn_Click;
            // 
            // ManageGroupOwner
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 444);
            Controls.Add(CreateNewOwnerGroupBtn);
            Controls.Add(PhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(GroupNameTextBox);
            Controls.Add(OwnerGroupListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageGroupOwner";
            Text = "ManageGroupOwner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox OwnerGroupListBox;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Button CreateNewOwnerGroupBtn;
    }
}