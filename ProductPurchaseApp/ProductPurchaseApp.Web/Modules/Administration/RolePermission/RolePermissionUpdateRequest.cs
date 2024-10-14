using Newtonsoft.Json;

namespace ProductPurchaseApp.Administration;
public class RolePermissionUpdateRequest : ServiceRequest
{
    public int? RoleID { get; set; }
    public List<string> Permissions { get; set; }
}