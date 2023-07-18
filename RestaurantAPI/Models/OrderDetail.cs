using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public long OrderDetailID { get; set; }

        public long OrderMasterID { get; set; }
        //even when we comment out OrderMaster, OrderMasterId got created as foreign key in OrderDetails.
        //we specified navigation property OrderDetail in form of list in OrderMaster file
        //public OrderMaster OrderMaster { get; set; } //navigation property

        public int FoodItemID { get; set; }
        public FoodItem FoodItem { get; set; } //navigation property

        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }

    }
}
