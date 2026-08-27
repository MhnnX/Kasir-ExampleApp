using System;
using System.Linq;
using System.Windows.Forms;
using Kasir_ExampleApp.Data;
using Kasir_ExampleApp.Models;

namespace Kasir_ExampleApp.Views
{
    public partial class ucTransactionContent : UserControl
    {
        private readonly AppDbContext _context;

        public ucTransactionContent()
        {
            InitializeComponent();
            _context = new AppDbContext();

            this.Load += ucTransactionContent_Load;

            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void ucTransactionContent_Load(object sender, EventArgs e)
        {
            LoadDataProducts();
        }

        private void LoadDataProducts()
        {
            var products = _context.Products.ToList();
            dgvProductList.DataSource = products;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var filteredProduct = _context.Products
                .Where(p => p.Name.ToLower().Contains(keyword))
                .ToList();

            dgvProductList.DataSource = filteredProduct;
        }
    }
}
