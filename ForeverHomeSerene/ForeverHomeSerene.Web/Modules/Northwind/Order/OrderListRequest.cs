using Serenity.Services;

namespace ForeverHomeSerene.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}