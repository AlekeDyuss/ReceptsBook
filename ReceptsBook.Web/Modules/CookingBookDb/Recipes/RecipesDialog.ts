import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { RecipesForm, RecipesRow, RecipesService } from '../../ServerTypes/CookingBookDb';

@Decorators.registerClass('ReceptsBook.CookingBookDb.RecipesDialog')
export class RecipesDialog extends EntityDialog<RecipesRow, any> {
    protected getFormKey() { return RecipesForm.formKey; }
    protected getRowDefinition() { return RecipesRow; }
    protected getService() { return RecipesService.baseUrl; }

    protected form = new RecipesForm(this.idPrefix);
}