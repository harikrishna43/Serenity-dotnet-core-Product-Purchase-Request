using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace ProductPurchaseApp.ProductPurchaseRequestDB;

[ConnectionKey("Default"), Module("ProductPurchaseRequestDB"), TableName("PurchaseRequest")]
[DisplayName("Product Purchase Request"), InstanceName("Product Purchase Request")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ProductPurchaseRequestRow : Row<ProductPurchaseRequestRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Purchase Request Id"), Identity, IdProperty]
    public int? PurchaseRequestId { get => fields.PurchaseRequestId[this]; set => fields.PurchaseRequestId[this] = value; }

    [DisplayName("User Id"), NotNull]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Product Name"), Size(2000), NotNull, QuickSearch, NameProperty]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    [DisplayName("Status"), Column("Status "), Size(100)]
    public string Status { get => fields.Status[this]; set => fields.Status[this] = value; }

    [DisplayName("Attachment"), Size(2000), NotNull]
    public string Attachment { get => fields.Attachment[this]; set => fields.Attachment[this] = value; }

    [DisplayName("Created Date"), Column("CreatedDate "), NotNull]
    public DateTime? CreatedDate { get => fields.CreatedDate[this]; set => fields.CreatedDate[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PurchaseRequestId;
        public Int32Field UserId;
        public StringField ProductName;
        public StringField Status;
        public StringField Attachment;
        public DateTimeField CreatedDate;

    }
}