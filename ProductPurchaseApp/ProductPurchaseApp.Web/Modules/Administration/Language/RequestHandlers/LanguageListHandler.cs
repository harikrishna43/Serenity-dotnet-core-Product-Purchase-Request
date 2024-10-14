using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ProductPurchaseApp.Administration.LanguageRow>;
using MyRow = ProductPurchaseApp.Administration.LanguageRow;


namespace ProductPurchaseApp.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}