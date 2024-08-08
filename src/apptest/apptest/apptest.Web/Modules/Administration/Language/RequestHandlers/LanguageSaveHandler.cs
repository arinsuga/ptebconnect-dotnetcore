using MyRequest = Serenity.Services.SaveRequest<apptest.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = apptest.Administration.LanguageRow;


namespace apptest.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}