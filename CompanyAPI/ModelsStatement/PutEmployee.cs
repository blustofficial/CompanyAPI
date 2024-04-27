using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsStatement
{
    public class PutEmployee
    {
        [Required]
        public int StatementId { get; set; }

        [Required]
        public int EmployeeId { get; set; }
    }
}
