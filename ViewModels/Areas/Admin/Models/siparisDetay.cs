namespace Commerce.Areas.Admin.Models
{
    public partial class siparisDetay
    {
        public int siparisId { get; set; }
        public int urunId { get; set; }
        public int miktar { get; set; }
        public int Id { get; set; }

        public virtual siparis sipariş { get; set; }
        public virtual urun urun { get; set; }
    }
}