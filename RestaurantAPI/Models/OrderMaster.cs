using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string OrderNumber { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; } //navigation property

        [Column(TypeName = "nvarchar(250)")]
        public string PayMethod { get; set; }

        public decimal GrandTotal { get; set; }

        //it is prolly a better idea to add navigation property in OrderMasters entity than OrderDetails
        //so added navigation property here
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
