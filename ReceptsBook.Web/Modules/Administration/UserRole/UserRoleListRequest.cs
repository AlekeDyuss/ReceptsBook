using Serenity.Services;

namespace ReceptsBook.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}