using Serenity.ComponentModel;
using System;

namespace ProductPurchaseApp.ProductPurchaseRequestDB.Forms;

[FormScript("ProductPurchaseRequestDB.ProductPurchaseRequest")]
[BasedOnRow(typeof(ProductPurchaseRequestRow), CheckNames = true)]
public class ProductPurchaseRequestForm
{
    //[ReadOnly(true)]
    //public int UserId { get; set; }
    public string ProductName { get; set; }
    public string Status { get; set; }
    [MultipleFileUploadEditor(FilenameFormat ="products/attachment/~")]
    public string Attachment { get; set; }
    [DateEditor]
    public DateTime CreatedDate { get; set; }
}