namespace OnlineCosmeticShop.Infrastructures
{
    using System.Security.Claims;

    using static Areas.Administration.AdminConstants;

    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
           => user.IsInRole(AdministratorRoleName);

        public static string Id(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
