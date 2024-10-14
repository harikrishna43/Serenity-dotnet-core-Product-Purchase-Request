using Serenity.Services;
using System.Net;
using MyRequest = Serenity.Services.SaveRequest<ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ProductPurchaseApp.ProductPurchaseRequestDB.ProductPurchaseRequestRow;

namespace ProductPurchaseApp.ProductPurchaseRequestDB;

public interface IProductPurchaseRequestSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductPurchaseRequestSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductPurchaseRequestSaveHandler
{

    public ProductPurchaseRequestSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    protected override void BeforeSave()
    {
        base.BeforeSave();
        if (User.IsInRole("User"))
        {
            Row.UserId = Convert.ToInt32(User.Identity.Name);
        }
    }
    protected override void ValidateRequired(HashSet<Field> editableFields)
    {
        foreach (var item in editableFields)
        {
            if(item.ColumnAlias== "UserId")
            {
                item.DefaultValue = Convert.ToInt32(AuthorizationExtensions.GetIdentifier(User));
            }
            
        }
        base.ValidateRequired(editableFields);
    }
}