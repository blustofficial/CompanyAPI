using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsStatement
{
    public class PutRole
    {
        [Required]
        public int StatementId { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}
