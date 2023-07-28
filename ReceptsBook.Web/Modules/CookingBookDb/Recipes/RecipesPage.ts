import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { RecipesGrid } from './RecipesGrid';

export default function pageInit() {
    initFullHeightGridPage(new RecipesGrid($('#GridDiv')).element);
}