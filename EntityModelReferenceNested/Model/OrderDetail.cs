using System.ComponentModel.DataAnnotations.Schema;
using EntityModelReferenceNested.Model.Base;

namespace EntityModelReferenceNested.Model;

[Table("OrderDetails", Schema = "Store")]
public class OrderDetail : OrderDetailBase
{
    [ForeignKey(nameof(OrderId))]
    public Order OrderNavigation { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Product ProductNavigation { get; set; }
}