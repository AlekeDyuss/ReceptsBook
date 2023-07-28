using FluentMigrator;
using System;

namespace ReceptsBook.Migrations.DefaultDB
{
    [Migration(20230728_095900)]
    public class DefaultDB_20230728_095900_ReceptsTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("recipe");

            Create.Table("Recipes").InSchema("recipe")
                .WithColumn("RecipeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(200).NotNullable()
                .WithColumn("CreatedDate").AsDateTime().Nullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Сooking").AsString(1000).Nullable();
                //.WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                // .WithColumn("Year").AsInt32().Nullable()
                //.WithColumn("PrimaryImage").AsString(100).Nullable()
                //.WithColumn("GalleryImages").AsString(int.MaxValue).Nullable();
                //.WithColumn("Runtime").AsInt32().Nullable();
        }
    }
}
