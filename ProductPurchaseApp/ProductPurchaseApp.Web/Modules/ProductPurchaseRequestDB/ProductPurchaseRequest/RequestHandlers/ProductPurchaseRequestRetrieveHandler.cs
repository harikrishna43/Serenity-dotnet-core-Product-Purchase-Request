using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow>;
using MyRow = ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow;

namespace ProductPurchaseApp.ProductPurchaseRequestDB;

public interface IProductPurchaseRequestRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductPurchaseRequestRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductPurchaseRequestRetrieveHandler
{
    public ProductPurchaseRequestRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
    protected override void OnBeforeExecuteQuery()
    {
        base.OnBeforeExecuteQuery();
        var data = User.Identities;
    }
}