using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.ModelsStatement
{
    public class GetById
    {
        [Required]
        public int StatementId { get; set; }
    }
}
