namespace Kasir_ExampleApp.Views
{
    partial class ucDashboardContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(323, 22);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang, Aplikasi Kasir ini.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(351, 18);
            label2.TabIndex = 1;
            label2.Text = "Tinjau Pengeluaran dan Pemasukkan Bisnis anda";
            // 
            // ucDashboardContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "ucDashboardContent";
            Size = new Size(708, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}
