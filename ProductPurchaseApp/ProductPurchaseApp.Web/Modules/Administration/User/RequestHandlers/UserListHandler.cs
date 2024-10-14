using MyRequest = ProductPurchaseApp.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<ProductPurchaseApp.Administration.UserRow>;
using MyRow = ProductPurchaseApp.Administration.UserRow;

namespace ProductPurchaseApp.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}