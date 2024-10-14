import { ProductPurchaseRequestColumns, ProductPurchaseRequestRow, ProductPurchaseRequestService } from '@/ServerTypes/ProductPurchaseRequestDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductPurchaseRequestDialog } from './ProductPurchaseRequestDialog';

@Decorators.registerClass('ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestGrid')
export class ProductPurchaseRequestGrid extends EntityGrid<ProductPurchaseRequestRow> {
    protected getColumnsKey() { return ProductPurchaseRequestColumns.columnsKey; }
    protected getDialogType() { return ProductPurchaseRequestDialog; }
    protected getRowDefinition() { return ProductPurchaseRequestRow; }
    protected getService() { return ProductPurchaseRequestService.baseUrl; }
}