import { StringEditor, DateEditor, TextAreaEditor, ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface RecipesForm {
    Title: StringEditor;
    CreatedDate: DateEditor;
    Description: TextAreaEditor;
    Ingredients: TextAreaEditor;
    Сooking: TextAreaEditor;
    Recommendations: StringEditor;
    PrimaryImage: ImageUploadEditor;
}

export class RecipesForm extends PrefixedContext {
    static formKey = 'CookingBookDb.Recipes';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RecipesForm.init)  {
            RecipesForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = TextAreaEditor;
            var w3 = ImageUploadEditor;

            initFormType(RecipesForm, [
                'Title', w0,
                'CreatedDate', w1,
                'Description', w2,
                'Ingredients', w2,
                'Сooking', w2,
                'Recommendations', w0,
                'PrimaryImage', w3
            ]);
        }
    }
}