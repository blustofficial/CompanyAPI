using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CompanyAPI.ModelsNews
{
    public class UpdateNews
    {
        [Required]
        public int Id { get; set; }

        [MaybeNull]
        public string Subject { get; set; }

        [MaybeNull]
        public string Description { get; set; }
    }
}
