using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<apptest.Administration.RoleRow>;
using MyRow = apptest.Administration.RoleRow;


namespace apptest.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}