using FluentMigrator;

namespace ProductPurchaseApp.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20141103_1500)]
public class DefaultDB_20141103_1500_Initial : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId32("PurchaseRequest", "PurchaseRequestId", s => s
            .WithColumn("UserId").AsInt32().NotNullable()
            .WithColumn("ProductName").AsString(2000).NotNullable()
            .WithColumn("Status ").AsString(100).Nullable()
            .WithColumn("Attachment").AsString(2000).NotNullable()
            .WithColumn("CreatedDate ").AsDateTime().NotNullable());
    }
}