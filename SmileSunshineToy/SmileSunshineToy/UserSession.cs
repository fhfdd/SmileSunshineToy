namespace SmileSunshineToy
{
    public enum UserRole
    {
        None, Admin, Sales, Inventory, Finance, Production, Logistics, Procurement, Personnel, RD
    }

    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static UserRole Role { get; set; }

        // Check if user has permission (Admin has all)
        public static bool HasPermission(UserRole requiredRole)
        {
            return Role == UserRole.Admin || Role == requiredRole;
        }
    }
}