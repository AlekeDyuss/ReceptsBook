using Serenity.ComponentModel;
using System;

namespace ReceptsBook.CookingBookDb.Forms;

[FormScript("CookingBookDb.Recipes")]
[BasedOnRow(typeof(RecipesRow), CheckNames = true)]
public class RecipesForm
{
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }

    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }

    [TextAreaEditor(Rows = 8)]
    public string Ingredients { get; set; }

    [TextAreaEditor(Rows = 10)]
    public string Сooking { get; set; }

    public string Recommendations { get; set; }
    public string PrimaryImage { get; set; }
    //public string GalleryImages { get; set; }
}