using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ProductPurchaseApp.Administration.RoleRow>;
using MyRow = ProductPurchaseApp.Administration.RoleRow;


namespace ProductPurchaseApp.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}