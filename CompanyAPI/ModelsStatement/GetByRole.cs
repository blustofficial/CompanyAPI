using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsStatement
{
    public class GetByRole
    {
        [Required]
        public int RoleId { get; set; }
    }
}
