using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kasir_ExampleApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nama_Barang { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Harga_Jual { get; set; }

        public int Stok { get; set; }

        [MaxLength(500)]
        public string ImagePath { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}