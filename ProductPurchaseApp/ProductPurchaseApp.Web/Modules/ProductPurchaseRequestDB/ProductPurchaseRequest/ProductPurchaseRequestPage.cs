using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Web;

namespace ProductPurchaseApp.ProductPurchaseRequestDB.Pages;

[PageAuthorize(typeof(ProductPurchaseRequestRow))]
public class ProductPurchaseRequestPage : Controller
{
   // private IUserDefinition _UserDefinition;
    public ProductPurchaseRequestPage()
    {
        //_UserDefinition= userDefinition;
    }
    [Route("ProductPurchaseRequestDB/ProductPurchaseRequest")]
    public ActionResult Index()
    {
        //var d=Convert.ToInt32(_UserDefinition.Id);
               return this.GridPage("@/ProductPurchaseRequestDB/ProductPurchaseRequest/ProductPurchaseRequestPage",
            ProductPurchaseRequestRow.Fields.PageTitle());
    }
}