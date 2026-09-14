using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_ExampleApp.Views.Card
{
    public partial class ProductCard : UserControl
    {
        public event EventHandler<int> OnProductSelected;
        private int _productId;

        public ProductCard()
        {
            InitializeComponent();
        }

        public void SetData(int id, string name, decimal price, Image img)
        {
            _productId = id;
            lblName.Text = name;

            lblPrice.Text = price.ToString("C");

            if (img != null)
            {
                picProduct.Image = img;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            OnProductSelected?.Invoke(this, _productId);
        }
    }
}
