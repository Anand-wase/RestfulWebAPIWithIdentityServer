using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MagicVilla_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String Name { get; set; } 
    }
}
