using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ReceptsBook.CookingBookDb.RecipesRow;

namespace ReceptsBook.CookingBookDb;

public interface IRecipesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class RecipesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRecipesDeleteHandler
{
    public RecipesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}