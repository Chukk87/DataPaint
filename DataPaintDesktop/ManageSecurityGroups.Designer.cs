namespace DataPaintDesktop
{
    partial class ManageSecurityGroups
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
            SecurityGroupCombobox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            NewSecurityGroupTextbox = new System.Windows.Forms.TextBox();
            CreateSecurityGroupBtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            SaveChnagesBtn = new System.Windows.Forms.Button();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            AdminListBox = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            radioButton6 = new System.Windows.Forms.RadioButton();
            UserListBox = new System.Windows.Forms.ListBox();
            AdminUserCombobox = new System.Windows.Forms.ComboBox();
            AddAdminBtn = new System.Windows.Forms.Button();
            AddUserBtn = new System.Windows.Forms.Button();
            UserCombobox = new System.Windows.Forms.ComboBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // SecurityGroupCombobox
            // 
            SecurityGroupCombobox.FormattingEnabled = true;
            SecurityGroupCombobox.Location = new System.Drawing.Point(103, 15);
            SecurityGroupCombobox.Name = "SecurityGroupCombobox";
            SecurityGroupCombobox.Size = new System.Drawing.Size(201, 23);
            SecurityGroupCombobox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Security Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 405);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 15);
            label2.TabIndex = 3;
            label2.Text = "New Security Group Name";
            // 
            // NewSecurityGroupTextbox
            // 
            NewSecurityGroupTextbox.Location = new System.Drawing.Point(165, 402);
            NewSecurityGroupTextbox.Name = "NewSecurityGroupTextbox";
            NewSecurityGroupTextbox.Size = new System.Drawing.Size(201, 23);
            NewSecurityGroupTextbox.TabIndex = 4;
            // 
            // CreateSecurityGroupBtn
            // 
            CreateSecurityGroupBtn.Location = new System.Drawing.Point(372, 402);
            CreateSecurityGroupBtn.Name = "CreateSecurityGroupBtn";
            CreateSecurityGroupBtn.Size = new System.Drawing.Size(75, 23);
            CreateSecurityGroupBtn.TabIndex = 5;
            CreateSecurityGroupBtn.Text = "Create";
            CreateSecurityGroupBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new System.Drawing.Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(292, 49);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Security Type";
            // 
            // SaveChnagesBtn
            // 
            SaveChnagesBtn.Location = new System.Drawing.Point(498, 401);
            SaveChnagesBtn.Name = "SaveChnagesBtn";
            SaveChnagesBtn.Size = new System.Drawing.Size(123, 23);
            SaveChnagesBtn.TabIndex = 7;
            SaveChnagesBtn.Text = "Save Changes";
            SaveChnagesBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(86, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "No Security";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(98, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(136, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Group User Run Only";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new System.Drawing.Point(323, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(298, 82);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Authorisation Change Type";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(165, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(97, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Group Admin";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(165, 48);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(116, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "No Authorisation";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(6, 48);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(153, 19);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "Any Security Group User";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // AdminListBox
            // 
            AdminListBox.FormattingEnabled = true;
            AdminListBox.ItemHeight = 15;
            AdminListBox.Location = new System.Drawing.Point(12, 163);
            AdminListBox.Name = "AdminListBox";
            AdminListBox.Size = new System.Drawing.Size(292, 184);
            AdminListBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "Group Admins";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(329, 136);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 15);
            label4.TabIndex = 12;
            label4.Text = "Group Users";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new System.Drawing.Point(6, 23);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new System.Drawing.Size(146, 19);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "Group Admin and User";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // UserListBox
            // 
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new System.Drawing.Point(329, 163);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new System.Drawing.Size(292, 184);
            UserListBox.TabIndex = 13;
            // 
            // AdminUserCombobox
            // 
            AdminUserCombobox.FormattingEnabled = true;
            AdminUserCombobox.Location = new System.Drawing.Point(12, 353);
            AdminUserCombobox.Name = "AdminUserCombobox";
            AdminUserCombobox.Size = new System.Drawing.Size(198, 23);
            AdminUserCombobox.TabIndex = 14;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.Location = new System.Drawing.Point(216, 353);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new System.Drawing.Size(88, 23);
            AddAdminBtn.TabIndex = 15;
            AddAdminBtn.Text = "Add Admin";
            AddAdminBtn.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new System.Drawing.Point(533, 353);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new System.Drawing.Size(88, 23);
            AddUserBtn.TabIndex = 17;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // UserCombobox
            // 
            UserCombobox.FormattingEnabled = true;
            UserCombobox.Location = new System.Drawing.Point(329, 353);
            UserCombobox.Name = "UserCombobox";
            UserCombobox.Size = new System.Drawing.Size(198, 23);
            UserCombobox.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(323, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(91, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Visible to All";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ManageSecurityGroups
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(630, 433);
            Controls.Add(checkBox1);
            Controls.Add(AddUserBtn);
            Controls.Add(UserCombobox);
            Controls.Add(AddAdminBtn);
            Controls.Add(AdminUserCombobox);
            Controls.Add(UserListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AdminListBox);
            Controls.Add(groupBox2);
            Controls.Add(SaveChnagesBtn);
            Controls.Add(groupBox1);
            Controls.Add(CreateSecurityGroupBtn);
            Controls.Add(NewSecurityGroupTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SecurityGroupCombobox);
            Name = "ManageSecurityGroups";
            Text = "ManageSecurityGroups";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox SecurityGroupCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewSecurityGroupTextbox;
        private System.Windows.Forms.Button CreateSecurityGroupBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button SaveChnagesBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListBox AdminListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.ComboBox AdminUserCombobox;
        private System.Windows.Forms.Button AddAdminBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.ComboBox UserCombobox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}