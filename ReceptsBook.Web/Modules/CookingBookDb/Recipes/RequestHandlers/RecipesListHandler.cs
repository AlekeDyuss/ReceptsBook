using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ReceptsBook.CookingBookDb.RecipesRow>;
using MyRow = ReceptsBook.CookingBookDb.RecipesRow;

namespace ReceptsBook.CookingBookDb;

public interface IRecipesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class RecipesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipesListHandler
{
    public RecipesListHandler(IRequestContext context)
            : base(context)
    {
    }
}