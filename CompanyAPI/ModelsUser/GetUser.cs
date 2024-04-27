using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsUser
{
    public class GetUser
    {
        [Required]
        public int Id { get; set; }
    }
}
