using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace ProductPurchaseApp.ProductPurchaseRequestDB.Columns;

[ColumnsScript("ProductPurchaseRequestDB.ProductPurchaseRequest")]
[BasedOnRow(typeof(ProductPurchaseRequestRow), CheckNames = true)]
public class ProductPurchaseRequestColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int PurchaseRequestId { get; set; }
    public int UserId { get; set; }
    [EditLink]
    public string ProductName { get; set; }
    public string Status { get; set; }
    public string Attachment { get; set; }
    public DateTime CreatedDate { get; set; }
}