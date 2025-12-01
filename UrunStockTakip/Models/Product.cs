using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UrunStokTakip.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(50, ErrorMessage = "Ürün adı en fazla 50 karakter olabilir.")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stok 0'dan küçük olamaz.")]
        public int Stock { get; set; }

        [Range(0.01, 999999, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        [Column(TypeName = "decimal(18,2)")] // SQL decimal hatasını önler
        public decimal Price { get; set; }
    }
}
