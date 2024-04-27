using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsUser
{
    public class DeleteUser
    {
        [Required]
        public int Id { get; set; }
    }
}
