using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ReceptsBook.CookingBookDb.RecipesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ReceptsBook.CookingBookDb.RecipesRow;

namespace ReceptsBook.CookingBookDb;

public interface IRecipesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class RecipesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipesSaveHandler
{
    public RecipesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}