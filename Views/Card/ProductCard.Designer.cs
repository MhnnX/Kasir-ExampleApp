namespace Kasir_ExampleApp.Views.Card
{
    partial class ProductCard
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
            panel1 = new Panel();
            picProduct = new PictureBox();
            panel2 = new Panel();
            btnAdd = new Button();
            lblName = new Label();
            lblPrice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 126);
            panel1.TabIndex = 0;
            // 
            // picProduct
            // 
            picProduct.Dock = DockStyle.Fill;
            picProduct.Location = new Point(0, 0);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(280, 126);
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 70);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 70);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+ Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Card_Click;
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblName.Location = new Point(-1, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(278, 35);
            lblName.TabIndex = 2;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.AutoEllipsis = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            lblPrice.Location = new Point(-1, 164);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(278, 35);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Rp. 10.000,00";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "ProductCard";
            Size = new Size(280, 280);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblName;
        private Label lblPrice;
        private Button btnAdd;
        private PictureBox picProduct;
    }
}
