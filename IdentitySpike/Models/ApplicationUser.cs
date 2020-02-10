using Microsoft.AspNetCore.Identity;
using System;

namespace IdentitySpike.Models
{

    public class Role : IdentityRole<Guid> { }

    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        public string DisplayName => string.IsNullOrEmpty(FirstName) ?
                                        Email : $"{FirstName} {LastName}";
    }
}
