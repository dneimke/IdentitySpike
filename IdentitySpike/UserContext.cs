using IdentitySpike.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace IdentitySpike
{
    public class UserContext
    {
        public UserContext(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> _userManager)
        {
            IsAuthenticated = httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
            if (IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(httpContextAccessor.HttpContext.User).Result;
                Name = user.DisplayName;
                Email = user.Email;
            }
        }

        public string Name { get; }
        public string Email { get; }
        public bool IsAuthenticated { get; }

    }
}
