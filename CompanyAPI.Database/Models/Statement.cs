using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Database.Models
{
    public class Statement
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }
        public int status { get; set; }
        public int user_id { get; set; }
        public int rating { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
