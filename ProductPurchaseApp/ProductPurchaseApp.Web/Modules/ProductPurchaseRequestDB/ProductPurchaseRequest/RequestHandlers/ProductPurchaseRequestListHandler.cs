using Serenity.Services;
using System.Security.Claims;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow>;
using MyRow = ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow;
using MyRepository = ProductPurchaseApp.Administration.Repositories.UserRoleRepository;
using ProductPurchaseApp.Administration;
namespace ProductPurchaseApp.ProductPurchaseRequestDB;

public interface IProductPurchaseRequestListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductPurchaseRequestListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductPurchaseRequestListHandler
{
    IUserRetrieveService _userRetrieveService;
    IRequestContext _RequestContext;
    public ProductPurchaseRequestListHandler(IRequestContext context, IUserRetrieveService userRetrieveService)
            : base(context)
    {
        _userRetrieveService = userRetrieveService;
        _RequestContext = context;
    }
    protected override void ApplyFilters(SqlQuery query)
    {
        var x = User.GetUserDefinition(_userRetrieveService);
        var userIdentity = (ClaimsIdentity)User.Identity;
        var claims = userIdentity.Claims;
        var roleClaimType = userIdentity.RoleClaimType;
        var roles = claims.Where(c => c.Type == ClaimTypes.Role).ToList();

        //if ()
        {
            query.Where($"UserId={Convert.ToInt32(AuthorizationExtensions.GetIdentifier(User))}");
        }
        base.ApplyFilters(query);
    }
}