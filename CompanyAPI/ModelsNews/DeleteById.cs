using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsNews
{
    public class DeleteById
    {
        [Required]
        public int Id { get; set; }
    }
}
