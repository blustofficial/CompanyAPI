using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CompanyAPI.ModelsUser
{
    public class PutUser
    {
        [Required]
        public int Id { get; set; }

        [MaybeNull]
        public string Name { get; set; }

        [MaybeNull]
        public string Password { get; set; }

        [MaybeNull]
        public int? RoleId { get; set; }
    }
}
