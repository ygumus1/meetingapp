using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo{
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen isim giriniz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Lütfen telefon numarası giriniz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Lütfen email giriniz.")]
        [EmailAddress(ErrorMessage ="Lütfen doğru bir e posta giriniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Lütfen katılma durumu giriniz.")]
        public bool WillAttend { get; set; }
    }
}