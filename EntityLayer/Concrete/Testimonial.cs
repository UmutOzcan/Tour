using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    // Referanslar icin tanımlamalar
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
