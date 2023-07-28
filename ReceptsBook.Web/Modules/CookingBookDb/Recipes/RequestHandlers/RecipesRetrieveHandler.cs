using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ReceptsBook.CookingBookDb.RecipesRow>;
using MyRow = ReceptsBook.CookingBookDb.RecipesRow;

namespace ReceptsBook.CookingBookDb;

public interface IRecipesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class RecipesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipesRetrieveHandler
{
    public RecipesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}