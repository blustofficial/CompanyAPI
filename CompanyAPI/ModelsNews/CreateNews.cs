using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CompanyAPI.ModelsNews
{
    public class CreateNews
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Description { get; set; }

        [MaybeNull]
        public int ParentId { get; set; }
    }
}
