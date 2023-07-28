using Serenity.Navigation;
using MovieDB = ReceptsBook.CookingBookDb.Pages;

[assembly: NavigationLink(1000, "CookingBookDb/Recipes", typeof(ReceptsBook.CookingBookDb.Pages.RecipesPage), icon: "fa-cutlery")]
[assembly: NavigationLink(2000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]