using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsUser
{
    public class PostUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}
