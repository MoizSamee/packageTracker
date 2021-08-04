using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PackageTracker.Models
{
    public class ShippingInfo
    {
        [Key]
        [DisplayName("Shipping ID")]
        public int Id { get; set; }

        

        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }

        /*[DisplayName("Package Number")]
        public int PackageNumber { get; set; }*/

        [DisplayName("Package Status")]
        public string PackageStatus { get; set; }

        [DisplayName("Package Weight")]
        public float weight { get; set; }

        [DisplayName("Source Address")]
        public string sourceAddress { get; set; }

        [DisplayName("Destination Address")]
        [Required]
        public string destinationAddress { get; set; }

        [DisplayName("Last Updated")]
        [DataType(DataType.Date)]
        public DateTime updatedTimestamp { get; set; }

        [DisplayName("Current Latitude")]
        public double? Latitude { get; set; }

        [DisplayName("Current Longitude")]
        public double? Longitude { get; set; }

        [DisplayName("Amout Paid")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string? deliveryImagePath { get; set; }


    }
}
