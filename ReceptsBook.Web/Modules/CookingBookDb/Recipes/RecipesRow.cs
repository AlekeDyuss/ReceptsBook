using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace ReceptsBook.CookingBookDb;

[ConnectionKey("Default"), Module("CookingBookDb"), TableName("[recipe].[Recipes]")]
[DisplayName("Recipes"), InstanceName("Recipes")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class RecipesRow : Row<RecipesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Recipe Id"), Identity, IdProperty]
    public int? RecipeId
    {
        get => fields.RecipeId[this];
        set => fields.RecipeId[this] = value;
    }

    [DisplayName("Наименование"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title
    {
        get => fields.Title[this];
        set => fields.Title[this] = value;
    }

    [DisplayName("Дата внесения")]
    public DateTime? CreatedDate
    {
        get => fields.CreatedDate[this];
        set => fields.CreatedDate[this] = value;
    }

    [DisplayName("Описание"), Size(1000)]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Ингредиенты"), Size(int.MaxValue)]
    public string Ingredients
    {
        get => fields.Ingredients[this];
        set => fields.Ingredients[this] = value;
    }

    [DisplayName("Приготовление"), Size(int.MaxValue)]
    public string Сooking
    {
        get => fields.Сooking[this];
        set => fields.Сooking[this] = value;
    }

    [DisplayName("Рекомендации"), Size(1000)]
    public string Recommendations
    {
        get => fields.Recommendations[this];
        set => fields.Recommendations[this] = value;
    }

    [DisplayName("Primary Image"), Size(100),
         ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
    public string PrimaryImage
    {
        get => fields.PrimaryImage[this];
        set => fields.PrimaryImage[this] = value;
    }

    //[DisplayName("Gallery Images"),
    // MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
    //public string GalleryImages
    //{
    //    //get => fields.GalleryImages[this];
    //    //set => fields.GalleryImages[this] = value;
    //}

    
    public class RowFields : RowFieldsBase
    {
        public Int32Field RecipeId;
        public StringField Title;
        public DateTimeField CreatedDate;
        public StringField Description;
        public StringField Сooking;
        public StringField Recommendations;
        public StringField PrimaryImage;
        public StringField Ingredients;
        //public StringField GalleryImages;

    }

}