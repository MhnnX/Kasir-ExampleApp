namespace Kasir_ExampleApp.Views
{
    partial class ucTransactionContent
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
            panelRight = new Panel();
            panel1 = new Panel();
            btnCheckout = new Button();
            panelPayment = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblChange = new Label();
            txtPayment = new TextBox();
            lblSubtotal = new Label();
            groupBox1 = new GroupBox();
            dgvCart = new DataGridView();
            productPanel = new Panel();
            dgvProductList = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            panelRight.SuspendLayout();
            panel1.SuspendLayout();
            panelPayment.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(panel1);
            panelRight.Controls.Add(panelPayment);
            panelRight.Controls.Add(groupBox1);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(615, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(363, 615);
            panelRight.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckout);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 153);
            panel1.TabIndex = 2;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Lime;
            btnCheckout.Dock = DockStyle.Bottom;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Location = new Point(0, 17);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(363, 136);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // panelPayment
            // 
            panelPayment.Controls.Add(label5);
            panelPayment.Controls.Add(label4);
            panelPayment.Controls.Add(label3);
            panelPayment.Controls.Add(lblChange);
            panelPayment.Controls.Add(txtPayment);
            panelPayment.Controls.Add(lblSubtotal);
            panelPayment.Dock = DockStyle.Top;
            panelPayment.Location = new Point(0, 185);
            panelPayment.Name = "panelPayment";
            panelPayment.Size = new Size(363, 278);
            panelPayment.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Change:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Subtotal:";
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(6, 157);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(354, 47);
            lblChange.TabIndex = 2;
            lblChange.Text = "1.000.000,00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPayment
            // 
            txtPayment.BorderStyle = BorderStyle.FixedSingle;
            txtPayment.Font = new Font("Arial", 16F);
            txtPayment.Location = new Point(6, 83);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(351, 32);
            txtPayment.TabIndex = 1;
            txtPayment.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(3, 18);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(354, 47);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "1.000.000,00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(dgvCart);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Product";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(3, 17);
            dgvCart.Name = "dgvCart";
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(357, 165);
            dgvCart.TabIndex = 0;
            // 
            // productPanel
            // 
            productPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productPanel.Controls.Add(dgvProductList);
            productPanel.Location = new Point(0, 105);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(615, 510);
            productPanel.TabIndex = 1;
            // 
            // dgvProductList
            // 
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(0, 0);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.Size = new Size(615, 510);
            dgvProductList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Product";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(17, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 29);
            txtSearch.TabIndex = 3;
            // 
            // ucTransactionContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(productPanel);
            Controls.Add(panelRight);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "ucTransactionContent";
            Size = new Size(978, 615);
            panelRight.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelPayment.ResumeLayout(false);
            panelPayment.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRight;
        private Panel productPanel;
        private DataGridView dgvProductList;
        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Panel panelPayment;
        private Label lblSubtotal;
        private DataGridView dgvCart;
        private TextBox txtPayment;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblChange;
        private Panel panel1;
        private Button btnCheckout;
    }
}
