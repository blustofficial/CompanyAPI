using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Database.Models
{
    public class Users
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string password { get; set; }

        public string email { get; set; }

        [Required]
        public int role_id { get; set; }

        public int company_id { get; set; }

        public string remember_token { get; set; }

        public DateTime? email_verified_at { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }
    }
}
