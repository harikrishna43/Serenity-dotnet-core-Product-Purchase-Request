import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProductPurchaseRequestRow } from "./ProductPurchaseRequestRow";

export namespace ProductPurchaseRequestService {
    export const baseUrl = 'ProductPurchaseRequestDB/ProductPurchaseRequest';

    export declare function Create(request: SaveRequest<ProductPurchaseRequestRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProductPurchaseRequestRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductPurchaseRequestRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProductPurchaseRequestRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductPurchaseRequestRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProductPurchaseRequestRow>>;

    export const Methods = {
        Create: "ProductPurchaseRequestDB/ProductPurchaseRequest/Create",
        Update: "ProductPurchaseRequestDB/ProductPurchaseRequest/Update",
        Delete: "ProductPurchaseRequestDB/ProductPurchaseRequest/Delete",
        Retrieve: "ProductPurchaseRequestDB/ProductPurchaseRequest/Retrieve",
        List: "ProductPurchaseRequestDB/ProductPurchaseRequest/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProductPurchaseRequestService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}