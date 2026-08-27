namespace Kasir_ExampleApp
{
    partial class frmDashboard
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
            panelMenu = new Panel();
            btnTransaction = new Button();
            btnDashboard = new Button();
            panelTopMenu = new Panel();
            txtRoleName = new Label();
            txtUsername = new Label();
            picboxUser = new PictureBox();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxUser).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.Controls.Add(btnTransaction);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelTopMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(383, 612);
            panelMenu.TabIndex = 0;
            // 
            // btnTransaction
            // 
            btnTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTransaction.BackColor = Color.Gainsboro;
            btnTransaction.FlatAppearance.BorderSize = 0;
            btnTransaction.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.Location = new Point(0, 139);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(383, 40);
            btnTransaction.TabIndex = 2;
            btnTransaction.Text = "Transaction";
            btnTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.BackColor = Color.Gainsboro;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 99);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(383, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.SkyBlue;
            panelTopMenu.Controls.Add(txtRoleName);
            panelTopMenu.Controls.Add(txtUsername);
            panelTopMenu.Controls.Add(picboxUser);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(383, 100);
            panelTopMenu.TabIndex = 0;
            // 
            // txtRoleName
            // 
            txtRoleName.AutoSize = true;
            txtRoleName.FlatStyle = FlatStyle.Flat;
            txtRoleName.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtRoleName.Location = new Point(110, 42);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(43, 19);
            txtRoleName.TabIndex = 2;
            txtRoleName.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.FlatStyle = FlatStyle.Flat;
            txtUsername.Font = new Font("Segoe UI Semilight", 12F);
            txtUsername.Location = new Point(110, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(79, 21);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            // 
            // picboxUser
            // 
            picboxUser.Location = new Point(12, 12);
            picboxUser.Name = "picboxUser";
            picboxUser.Size = new Size(92, 81);
            picboxUser.TabIndex = 0;
            picboxUser.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(383, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(741, 612);
            panelContent.TabIndex = 1;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 612);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnDashboard;
        private Panel panelTopMenu;
        private Button btnTransaction;
        private Label txtRoleName;
        private Label txtUsername;
        private PictureBox picboxUser;
        private Panel panelContent;
    }
}
