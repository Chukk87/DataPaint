
namespace DataPaintDesktop
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            SetupOrientationBtn = new System.Windows.Forms.Button();
            ManageGroupOwnerBtn = new System.Windows.Forms.Button();
            ManageSecurityGroupsBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(819, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // SetupOrientationBtn
            // 
            SetupOrientationBtn.Location = new System.Drawing.Point(153, 135);
            SetupOrientationBtn.Name = "SetupOrientationBtn";
            SetupOrientationBtn.Size = new System.Drawing.Size(214, 23);
            SetupOrientationBtn.TabIndex = 1;
            SetupOrientationBtn.Text = "Set up a New Orientation";
            SetupOrientationBtn.UseVisualStyleBackColor = true;
            SetupOrientationBtn.Click += SetupOrientationBtn_Click;
            // 
            // ManageGroupOwnerBtn
            // 
            ManageGroupOwnerBtn.Location = new System.Drawing.Point(153, 77);
            ManageGroupOwnerBtn.Name = "ManageGroupOwnerBtn";
            ManageGroupOwnerBtn.Size = new System.Drawing.Size(214, 23);
            ManageGroupOwnerBtn.TabIndex = 2;
            ManageGroupOwnerBtn.Text = "Manage Group Owners";
            ManageGroupOwnerBtn.UseVisualStyleBackColor = true;
            ManageGroupOwnerBtn.Click += ManageGroupOwnerBtn_Click;
            // 
            // ManageSecurityGroupsBtn
            // 
            ManageSecurityGroupsBtn.Location = new System.Drawing.Point(153, 106);
            ManageSecurityGroupsBtn.Name = "ManageSecurityGroupsBtn";
            ManageSecurityGroupsBtn.Size = new System.Drawing.Size(214, 23);
            ManageSecurityGroupsBtn.TabIndex = 3;
            ManageSecurityGroupsBtn.Text = "Manage Security Groups";
            ManageSecurityGroupsBtn.UseVisualStyleBackColor = true;
            ManageSecurityGroupsBtn.Click += ManageSecurityGroupsBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(819, 450);
            Controls.Add(ManageSecurityGroupsBtn);
            Controls.Add(ManageGroupOwnerBtn);
            Controls.Add(SetupOrientationBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button SetupOrientationBtn;
        private System.Windows.Forms.Button ManageGroupOwnerBtn;
        private System.Windows.Forms.Button ManageSecurityGroupsBtn;
    }
}

