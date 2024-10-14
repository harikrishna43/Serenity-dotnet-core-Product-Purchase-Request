using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow;

namespace ProductPurchaseApp.ProductPurchaseRequestDB;

public interface IProductPurchaseRequestDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductPurchaseRequestDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductPurchaseRequestDeleteHandler
{
    public ProductPurchaseRequestDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}