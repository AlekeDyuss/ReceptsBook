using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ReceptsBook.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ReceptsBook.Administration.LanguageRow;


namespace ReceptsBook.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}