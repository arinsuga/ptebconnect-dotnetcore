using MyRequest = apptest.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<apptest.Administration.UserRow>;
using MyRow = apptest.Administration.UserRow;

namespace apptest.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}