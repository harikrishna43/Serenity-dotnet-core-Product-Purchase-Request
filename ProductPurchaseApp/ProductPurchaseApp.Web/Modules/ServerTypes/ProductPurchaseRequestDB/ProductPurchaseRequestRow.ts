import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductPurchaseRequestRow {
    PurchaseRequestId?: number;
    UserId?: number;
    ProductName?: string;
    Status?: string;
    Attachment?: string;
    CreatedDate?: string;
}

export abstract class ProductPurchaseRequestRow {
    static readonly idProperty = 'PurchaseRequestId';
    static readonly nameProperty = 'ProductName';
    static readonly localTextPrefix = 'ProductPurchaseRequestDB.ProductPurchaseRequest';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProductPurchaseRequestRow>();
}