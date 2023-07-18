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
        //public OrderMaster OrderMaster { get; set; } //navigation property

        public int FoodItemID { get; set; }
        public FoodItem FoodItem { get; set; } //navigation property

        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }

    }
}
