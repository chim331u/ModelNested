using System.ComponentModel.DataAnnotations.Schema;
using EntityModelReferenceNested.Model.Base;

namespace EntityModelReferenceNested.Model;

[Table("Orders", Schema = "Store")]
public class Order : OrderBase
{
    [ForeignKey(nameof(CustomerId))]
    public Customer CustomerNavigation { get; set; }

    [InverseProperty(nameof(OrderDetail.OrderNavigation))]
    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}