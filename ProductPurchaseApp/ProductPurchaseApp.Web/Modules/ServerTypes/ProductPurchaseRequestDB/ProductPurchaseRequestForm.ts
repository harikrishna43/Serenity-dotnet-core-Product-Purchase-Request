import { StringEditor, MultipleImageUploadEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductPurchaseRequestForm {
    ProductName: StringEditor;
    Status: StringEditor;
    Attachment: MultipleImageUploadEditor;
    CreatedDate: DateEditor;
}

export class ProductPurchaseRequestForm extends PrefixedContext {
    static readonly formKey = 'ProductPurchaseRequestDB.ProductPurchaseRequest';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductPurchaseRequestForm.init)  {
            ProductPurchaseRequestForm.init = true;

            var w0 = StringEditor;
            var w1 = MultipleImageUploadEditor;
            var w2 = DateEditor;

            initFormType(ProductPurchaseRequestForm, [
                'ProductName', w0,
                'Status', w0,
                'Attachment', w1,
                'CreatedDate', w2
            ]);
        }
    }
}