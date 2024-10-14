import { ProductPurchaseRequestForm, ProductPurchaseRequestRow, ProductPurchaseRequestService } from '@/ServerTypes/ProductPurchaseRequestDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestDialog')
export class ProductPurchaseRequestDialog extends EntityDialog<ProductPurchaseRequestRow, any> {
    protected getFormKey() { return ProductPurchaseRequestForm.formKey; }
    protected getRowDefinition() { return ProductPurchaseRequestRow; }
    protected getService() { return ProductPurchaseRequestService.baseUrl; }

    protected form = new ProductPurchaseRequestForm(this.idPrefix);
}