using FluentMigrator;
using System;

namespace ReceptsBook.Migrations.DefaultDB
{
    [Migration(20230728_121400)]
    public class DefaultDB_20230728_121400_ReceptsTable : AutoReversingMigration
    {
        public override void Up()
        {
            //Create.Schema("recipe");

            Alter.Table("Recipes").InSchema("recipe")
                //.WithColumn("RecipeId").AsInt32()
                //    .Identity().PrimaryKey().NotNullable()
                //.WithColumn("Title").AsString(200).NotNullable()
                //.WithColumn("CreatedDate").AsDateTime().Nullable()
                //.WithColumn("Description").AsString(1000).Nullable()
                //.AlterColumn("Сooking").AsString(int.MaxValue).Nullable();
                //.WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                // .WithColumn("Year").AsInt32().Nullable()
                //.WithColumn("PrimaryImage").AsString(100).Nullable()
                //.WithColumn("GalleryImages").AsString(int.MaxValue).Nullable();
                //.WithColumn("Runtime").AsInt32().Nullable();
                //.AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("Ingredients").AsString(int.MaxValue).Nullable();
        }
    }
}
