using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace ReceptsBook.CookingBookDb.Columns;

[ColumnsScript("CookingBookDb.Recipes")]
[BasedOnRow(typeof(RecipesRow), CheckNames = true)]
public class RecipesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int RecipeId { get; set; }
    [EditLink]
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public string Ingredients { get; set; }
    public string Сooking { get; set; }
    public string Recommendations { get; set; }
}