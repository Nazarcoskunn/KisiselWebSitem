
using System.ComponentModel.DataAnnotations;


namespace WebApplication33333.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi{ get; set; }
        public int sifre{ get; set; }
    }
}