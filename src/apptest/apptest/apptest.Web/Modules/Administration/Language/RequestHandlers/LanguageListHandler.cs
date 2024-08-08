using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<apptest.Administration.LanguageRow>;
using MyRow = apptest.Administration.LanguageRow;


namespace apptest.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}