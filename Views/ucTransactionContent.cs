using Kasir_ExampleApp.Data;
using Kasir_ExampleApp.Helpers;
using System.ComponentModel;
using System.Drawing.Printing;

namespace Kasir_ExampleApp.Views
{
    public partial class ucTransactionContent : UserControl
    {
        private readonly AppDbContext _context;
        private BindingList<CartItem> _cartList;

        public ucTransactionContent()
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.Load += ucTransactionContent_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtPayment.KeyPress += TxtPayment_KeyPress;
            txtPayment.TextChanged += TxtPayment_TextChanged;
            btnCheckout.Click += BtnCheckout_Click;

            _cartList = new BindingList<CartItem>();
            dgvCart.DataSource = _cartList;
            dgvCart.Columns["Id"].Visible = false;
            dgvCart.Columns["HargaJual"].Visible = false;
            dgvCart.Columns["Subtotal"].Visible = false;
            dgvCart.Columns["NamaProduk"].HeaderText = "Nama Produk";
            dgvCart.Columns["Harga"].HeaderText = "Harga";
            dgvCart.Columns["Qty"].HeaderText = "Jumlah";

            dgvCart.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCart.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void ucTransactionContent_Load(object sender, EventArgs e)
        {
            RenderProductCards();
        }

        private void RenderProductCards(string keyword = "")
        {
            flowLayoutPanelProducts.SuspendLayout();
            flowLayoutPanelProducts.Controls.Clear();

            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(p => p.Nama_Barang.ToLower().Contains(keyword.ToLower()));
            }

            var products = query.ToList();

            foreach (var product in products)
            {
                var card = new Kasir_ExampleApp.Views.Card.ProductCard();

                Image productImage = null;

                card.SetData(product.Id, product.Nama_Barang, product.Harga_Jual, productImage);
                card.OnProductSelected += Card_OnProductSelected;

                flowLayoutPanelProducts.Controls.Add(card);
            }

            flowLayoutPanelProducts.ResumeLayout();
        }

        private void Card_OnProductSelected(object sender, int productId)
        {
            var existingItem = _cartList.FirstOrDefault(c => c.Id == productId);

            if (existingItem != null)
            {
                existingItem.Qty += 1;
                _cartList.ResetBindings();
            }
            else
            {
                var product = _context.Products.Find(productId);
                if (product != null)
                {
                    _cartList.Add(new CartItem
                    {
                        Id = product.Id,
                        NamaProduk = product.Nama_Barang,
                        HargaJual = product.Harga_Jual,
                        Qty = 1
                    });
                }
            }
            HitungGrandTotal();
        }

        private void HitungGrandTotal()
        {
            decimal total = _cartList.Sum(item => item.Subtotal);
            lblSubtotal.Text = total.ToRupiah();

            if (decimal.TryParse(txtPayment.Text.Replace(".", ""), out decimal payment))
            {
                HitungKembalian(payment);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            RenderProductCards(keyword);
        }

        private void TxtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPayment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayment.Text))
            {
                lblChange.Text = "0";
                lblChange.ForeColor = Color.Black;
                return;
            }

            string rawText = txtPayment.Text.Replace(".", "");

            if (decimal.TryParse(rawText, out decimal payment))
            {
                txtPayment.TextChanged -= TxtPayment_TextChanged;
                txtPayment.Text = payment.ToString("N0", new System.Globalization.CultureInfo("id-ID"));
                txtPayment.SelectionStart = txtPayment.Text.Length;
                txtPayment.TextChanged += TxtPayment_TextChanged;

                HitungKembalian(payment);
            }
        }

        private void HitungKembalian(decimal payment)
        {
            decimal totalBelanja = _cartList.Sum(item => item.Subtotal);
            decimal kembalian = payment - totalBelanja;

            if (kembalian < 0)
            {
                lblChange.Text = "Kurang: " + Math.Abs(kembalian).ToString("N0", new System.Globalization.CultureInfo("id-ID"));
                lblChange.ForeColor = Color.Red;
            }
            else
            {
                lblChange.Text = kembalian.ToString("N0", new System.Globalization.CultureInfo("id-ID"));
                lblChange.ForeColor = Color.Black;
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (_cartList.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = _cartList.Sum(item => item.Subtotal);
            decimal.TryParse(txtPayment.Text.Replace(".", ""), out decimal payment);

            if (payment < total)
            {
                MessageBox.Show("Uang pembayaran tidak mencukupi!", "Transaksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += CetakStruk_PrintPage;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

            _cartList.Clear();
            txtPayment.Text = "";
            lblChange.Text = "0";
            HitungGrandTotal();
        }

        private void CetakStruk_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontRegular = new Font("Courier New", 10);
            Font fontBold = new Font("Courier New", 12, FontStyle.Bold);
            int y = 20; 

            g.DrawString("TOKO KASIR EXAMPLE", fontBold, Brushes.Black, new PointF(60, y));
            y += 30;
            g.DrawString("-----------------------------------", fontRegular, Brushes.Black, new PointF(10, y));
            y += 20;

            foreach (var item in _cartList)
            {
                g.DrawString(item.NamaProduk, fontRegular, Brushes.Black, new PointF(10, y));
                y += 20;

                string detailQtyHarga = $"{item.Qty}x {item.Harga}";
                g.DrawString(detailQtyHarga, fontRegular, Brushes.Black, new PointF(10, y));

                g.DrawString(item.Subtotal.ToRupiah(), fontRegular, Brushes.Black, new PointF(220, y));
                y += 20;
            }

            g.DrawString("-----------------------------------", fontRegular, Brushes.Black, new PointF(10, y));
            y += 20;
            g.DrawString($"Total   : {lblSubtotal.Text}", fontBold, Brushes.Black, new PointF(10, y));
            y += 20;
            g.DrawString($"Bayar   : {paymentFormatted()}", fontRegular, Brushes.Black, new PointF(10, y));
            y += 20;
            g.DrawString($"Kembali : {lblChange.Text}", fontRegular, Brushes.Black, new PointF(10, y));
            y += 40;
            g.DrawString("Terima Kasih Atas Kunjungan Anda", fontRegular, Brushes.Black, new PointF(30, y));
        }

        private string paymentFormatted()
        {
            decimal.TryParse(txtPayment.Text.Replace(".", ""), out decimal payment);
            return payment.ToString("N0", new System.Globalization.CultureInfo("id-ID"));
        }
    }

    public class CartItem
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public decimal HargaJual { get; set; }
        public string Harga => HargaJual.ToRupiah();
        public int Qty { get; set; }
        public decimal Subtotal => HargaJual * Qty;
    }
}
