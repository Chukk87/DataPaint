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
            GroupUserRunSecurityRadio = new System.Windows.Forms.RadioButton();
            NoSecurityRadio = new System.Windows.Forms.RadioButton();
            SaveChnagesBtn = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            GroupAdminAndUserRadio = new System.Windows.Forms.RadioButton();
            AnyRadio = new System.Windows.Forms.RadioButton();
            GroupAdminRadio = new System.Windows.Forms.RadioButton();
            NoneRadio = new System.Windows.Forms.RadioButton();
            AdminListBox = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            UserListBox = new System.Windows.Forms.ListBox();
            AdminUserCombobox = new System.Windows.Forms.ComboBox();
            AddAdminBtn = new System.Windows.Forms.Button();
            AddUserBtn = new System.Windows.Forms.Button();
            UserCombobox = new System.Windows.Forms.ComboBox();
            VisibleToAllCheckBox = new System.Windows.Forms.CheckBox();
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
            SecurityGroupCombobox.SelectedIndexChanged += SecurityGroupCombobox_SelectedIndexChanged;
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
            CreateSecurityGroupBtn.Click += CreateSecurityGroupBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GroupUserRunSecurityRadio);
            groupBox1.Controls.Add(NoSecurityRadio);
            groupBox1.Location = new System.Drawing.Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(292, 49);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Security Type";
            // 
            // GroupUserRunSecurityRadio
            // 
            GroupUserRunSecurityRadio.AutoSize = true;
            GroupUserRunSecurityRadio.Location = new System.Drawing.Point(98, 22);
            GroupUserRunSecurityRadio.Name = "GroupUserRunSecurityRadio";
            GroupUserRunSecurityRadio.Size = new System.Drawing.Size(136, 19);
            GroupUserRunSecurityRadio.TabIndex = 8;
            GroupUserRunSecurityRadio.TabStop = true;
            GroupUserRunSecurityRadio.Text = "Group User Run Only";
            GroupUserRunSecurityRadio.UseVisualStyleBackColor = true;
            // 
            // NoSecurityRadio
            // 
            NoSecurityRadio.AutoSize = true;
            NoSecurityRadio.Location = new System.Drawing.Point(6, 22);
            NoSecurityRadio.Name = "NoSecurityRadio";
            NoSecurityRadio.Size = new System.Drawing.Size(86, 19);
            NoSecurityRadio.TabIndex = 0;
            NoSecurityRadio.TabStop = true;
            NoSecurityRadio.Text = "No Security";
            NoSecurityRadio.UseVisualStyleBackColor = true;
            // 
            // SaveChnagesBtn
            // 
            SaveChnagesBtn.Location = new System.Drawing.Point(498, 401);
            SaveChnagesBtn.Name = "SaveChnagesBtn";
            SaveChnagesBtn.Size = new System.Drawing.Size(123, 23);
            SaveChnagesBtn.TabIndex = 7;
            SaveChnagesBtn.Text = "Save Changes";
            SaveChnagesBtn.UseVisualStyleBackColor = true;
            SaveChnagesBtn.Click += SaveChnagesBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GroupAdminAndUserRadio);
            groupBox2.Controls.Add(AnyRadio);
            groupBox2.Controls.Add(GroupAdminRadio);
            groupBox2.Controls.Add(NoneRadio);
            groupBox2.Location = new System.Drawing.Point(323, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(298, 82);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Authorisation Change Type";
            // 
            // GroupAdminAndUserRadio
            // 
            GroupAdminAndUserRadio.AutoSize = true;
            GroupAdminAndUserRadio.Location = new System.Drawing.Point(6, 23);
            GroupAdminAndUserRadio.Name = "GroupAdminAndUserRadio";
            GroupAdminAndUserRadio.Size = new System.Drawing.Size(146, 19);
            GroupAdminAndUserRadio.TabIndex = 10;
            GroupAdminAndUserRadio.TabStop = true;
            GroupAdminAndUserRadio.Text = "Group Admin and User";
            GroupAdminAndUserRadio.UseVisualStyleBackColor = true;
            // 
            // AnyRadio
            // 
            AnyRadio.AutoSize = true;
            AnyRadio.Location = new System.Drawing.Point(6, 48);
            AnyRadio.Name = "AnyRadio";
            AnyRadio.Size = new System.Drawing.Size(153, 19);
            AnyRadio.TabIndex = 9;
            AnyRadio.TabStop = true;
            AnyRadio.Text = "Any Security Group User";
            AnyRadio.UseVisualStyleBackColor = true;
            // 
            // GroupAdminRadio
            // 
            GroupAdminRadio.AutoSize = true;
            GroupAdminRadio.Location = new System.Drawing.Point(165, 22);
            GroupAdminRadio.Name = "GroupAdminRadio";
            GroupAdminRadio.Size = new System.Drawing.Size(97, 19);
            GroupAdminRadio.TabIndex = 8;
            GroupAdminRadio.TabStop = true;
            GroupAdminRadio.Text = "Group Admin";
            GroupAdminRadio.UseVisualStyleBackColor = true;
            // 
            // NoneRadio
            // 
            NoneRadio.AutoSize = true;
            NoneRadio.Location = new System.Drawing.Point(165, 48);
            NoneRadio.Name = "NoneRadio";
            NoneRadio.Size = new System.Drawing.Size(116, 19);
            NoneRadio.TabIndex = 0;
            NoneRadio.TabStop = true;
            NoneRadio.Text = "No Authorisation";
            NoneRadio.UseVisualStyleBackColor = true;
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
            AddAdminBtn.Click += AddAdminBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new System.Drawing.Point(533, 353);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new System.Drawing.Size(88, 23);
            AddUserBtn.TabIndex = 17;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // UserCombobox
            // 
            UserCombobox.FormattingEnabled = true;
            UserCombobox.Location = new System.Drawing.Point(329, 353);
            UserCombobox.Name = "UserCombobox";
            UserCombobox.Size = new System.Drawing.Size(198, 23);
            UserCombobox.TabIndex = 16;
            // 
            // VisibleToAllCheckBox
            // 
            VisibleToAllCheckBox.AutoSize = true;
            VisibleToAllCheckBox.Location = new System.Drawing.Point(323, 14);
            VisibleToAllCheckBox.Name = "VisibleToAllCheckBox";
            VisibleToAllCheckBox.Size = new System.Drawing.Size(91, 19);
            VisibleToAllCheckBox.TabIndex = 18;
            VisibleToAllCheckBox.Text = "Visible to All";
            VisibleToAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManageSecurityGroups
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(630, 433);
            Controls.Add(VisibleToAllCheckBox);
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
        private System.Windows.Forms.RadioButton NoSecurityRadio;
        private System.Windows.Forms.Button SaveChnagesBtn;
        private System.Windows.Forms.RadioButton GroupUserRunSecurityRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AnyRadio;
        private System.Windows.Forms.RadioButton GroupAdminRadio;
        private System.Windows.Forms.RadioButton NoneRadio;
        private System.Windows.Forms.ListBox AdminListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton GroupAdminAndUserRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.ComboBox AdminUserCombobox;
        private System.Windows.Forms.Button AddAdminBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.ComboBox UserCombobox;
        private System.Windows.Forms.CheckBox VisibleToAllCheckBox;
    }
}