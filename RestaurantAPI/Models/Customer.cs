using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        //making thi attribute a required property, specifying the string's type in the db, setting a default val if no val provided
        //since this is a "Required" property
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

    }
}
