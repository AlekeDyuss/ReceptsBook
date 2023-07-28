import { fieldsProxy } from "@serenity-is/corelib/q";

export interface RecipesRow {
    RecipeId?: number;
    Title?: string;
    CreatedDate?: string;
    Description?: string;
    Сooking?: string;
    Recommendations?: string;
    PrimaryImage?: string;
    Ingredients?: string;
}

export abstract class RecipesRow {
    static readonly idProperty = 'RecipeId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'CookingBookDb.Recipes';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<RecipesRow>();
}