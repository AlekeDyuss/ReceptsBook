using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ReceptsBook.CookingBookDb.Pages;

[PageAuthorize(typeof(RecipesRow))]
public class RecipesPage : Controller
{
    [Route("CookingBookDb/Recipes")]
    public ActionResult Index()
    {
        return this.GridPage("@/CookingBookDb/Recipes/RecipesPage",
            RecipesRow.Fields.PageTitle());
    }
}