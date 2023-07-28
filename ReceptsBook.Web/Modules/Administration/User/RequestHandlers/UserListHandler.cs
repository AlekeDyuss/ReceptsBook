using Serenity.Services;
using MyRequest = ReceptsBook.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<ReceptsBook.Administration.UserRow>;
using MyRow = ReceptsBook.Administration.UserRow;

namespace ReceptsBook.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}