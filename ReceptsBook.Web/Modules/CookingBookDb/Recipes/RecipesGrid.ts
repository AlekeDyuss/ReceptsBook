import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { RecipesColumns, RecipesRow, RecipesService } from '../../ServerTypes/CookingBookDb';
import { RecipesDialog } from './RecipesDialog';

@Decorators.registerClass('ReceptsBook.CookingBookDb.RecipesGrid')
export class RecipesGrid extends EntityGrid<RecipesRow, any> {
    protected getColumnsKey() { return RecipesColumns.columnsKey; }
    protected getDialogType() { return RecipesDialog; }
    protected getRowDefinition() { return RecipesRow; }
    protected getService() { return RecipesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}