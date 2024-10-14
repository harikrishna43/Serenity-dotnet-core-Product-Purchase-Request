import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductPurchaseRequestRow } from "./ProductPurchaseRequestRow";

export interface ProductPurchaseRequestColumns {
    PurchaseRequestId: Column<ProductPurchaseRequestRow>;
    UserId: Column<ProductPurchaseRequestRow>;
    ProductName: Column<ProductPurchaseRequestRow>;
    Status: Column<ProductPurchaseRequestRow>;
    Attachment: Column<ProductPurchaseRequestRow>;
    CreatedDate: Column<ProductPurchaseRequestRow>;
}

export class ProductPurchaseRequestColumns extends ColumnsBase<ProductPurchaseRequestRow> {
    static readonly columnsKey = 'ProductPurchaseRequestDB.ProductPurchaseRequest';
    static readonly Fields = fieldsProxy<ProductPurchaseRequestColumns>();
}