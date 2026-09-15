namespace Kasir_ExampleApp
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            cbShowPassword = new CheckBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 44);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 0;
            label1.Text = "LOGIN ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(102, 164);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ketik username anda...";
            txtUsername.Size = new Size(245, 23);
            txtUsername.TabIndex = 2;
            txtUsername.WordWrap = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(102, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "ketik password anda...";
            txtPassword.Size = new Size(245, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 204);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(102, 257);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(103, 18);
            cbShowPassword.TabIndex = 5;
            cbShowPassword.Text = "Lihat password";
            cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(118, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(209, 56);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "SIGN-IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(174, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 14);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gajadi, males login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(445, 487);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(cbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private CheckBox cbShowPassword;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}