namespace DataPaintDesktop
{
    partial class NewOwnerGroupForm
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
            PhoneTextBox = new System.Windows.Forms.TextBox();
            EmailTextBox = new System.Windows.Forms.TextBox();
            GroupNameTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            CreateNewOwnerGroupBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new System.Drawing.Point(109, 54);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new System.Drawing.Size(253, 23);
            PhoneTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new System.Drawing.Point(109, 30);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new System.Drawing.Size(253, 23);
            EmailTextBox.TabIndex = 11;
            // 
            // GroupNameTextBox
            // 
            GroupNameTextBox.Location = new System.Drawing.Point(109, 6);
            GroupNameTextBox.Name = "GroupNameTextBox";
            GroupNameTextBox.Size = new System.Drawing.Size(253, 23);
            GroupNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 8;
            label2.Text = "Contact Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Group Name";
            // 
            // CreateNewOwnerGroupBtn
            // 
            CreateNewOwnerGroupBtn.Location = new System.Drawing.Point(183, 83);
            CreateNewOwnerGroupBtn.Name = "CreateNewOwnerGroupBtn";
            CreateNewOwnerGroupBtn.Size = new System.Drawing.Size(179, 23);
            CreateNewOwnerGroupBtn.TabIndex = 13;
            CreateNewOwnerGroupBtn.Text = "Create New Owner Group";
            CreateNewOwnerGroupBtn.UseVisualStyleBackColor = true;
            CreateNewOwnerGroupBtn.Click += CreateNewOwnerGroupBtn_Click;
            // 
            // NewOwnerGroupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(371, 112);
            Controls.Add(CreateNewOwnerGroupBtn);
            Controls.Add(PhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(GroupNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewOwnerGroupForm";
            Text = "NewOwnerGroupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewOwnerGroupBtn;
    }
}