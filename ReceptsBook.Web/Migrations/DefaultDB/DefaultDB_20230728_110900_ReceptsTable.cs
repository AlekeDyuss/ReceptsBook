using FluentMigrator;
using System;

namespace ReceptsBook.Migrations.DefaultDB
{
    [Migration(20230728_110900)]
    public class DefaultDB_20230728_110900_ReceptsTable : AutoReversingMigration
    {
        public override void Up()
        {
            //Create.Schema("recipe");

            Alter.Table("Recipes").InSchema("recipe")
                //.AddColumn("RecipeId").AsInt32()
                  //  .Identity().PrimaryKey().NotNullable()
                //.AddColumn("Title").AsString(200).NotNullable()
                //.AddColumn("CreatedDate").AsDateTime().Nullable()
                .AlterColumn("Description").AsString(int.MaxValue).Nullable()
                .AddColumn("Recommendations").AsString(1000).Nullable();
                //.WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                // .WithColumn("Year").AsInt32().Nullable()
                //.WithColumn("PrimaryImage").AsString(100).Nullable()
                //.WithColumn("GalleryImages").AsString(int.MaxValue).Nullable();
                //.WithColumn("Runtime").AsInt32().Nullable();
        }
    }
}
