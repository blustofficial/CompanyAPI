using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsNews
{
    public class GetById
    {
        [Required]
        public int Id { get; set; }
    }
}
