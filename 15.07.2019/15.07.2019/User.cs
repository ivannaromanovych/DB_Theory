using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _15._07._2019
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        public override string ToString()
        {
            string ret = Id + ' ' + Login + ' ' + Password + ' ' + Address + ' ' + PhoneNumber;
            if (IsAdmin)
                ret = ret + " Admin";
            return ret;
        }
    }
}