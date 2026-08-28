using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kasir_ExampleApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nama_Barang { get; set; }

        [Precision(18, 2)]
        public decimal Harga_Beli { get; set; }

        [Precision(18, 2)]
        public decimal Harga_Jual { get; set; }
        public int Stok { get; set; }
        public int Id_Kategori { get; set; }

        [ForeignKey("Id_Kategori")]
        public Category Category { get; set; }
    }
}