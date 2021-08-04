using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PackageTracker.Models
{
    public class CustomerInfo
    {
        [Key]
        [Display(Name ="Customer ID")]
        public int CustId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "First is Required")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Last is Required")]
        public string lastName { get; set; }


        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        [Display(Name ="Customer Address")]
        public string CustAddress { get; set; }

        [Display(Name = "Phone No")]
        /*[Phone]*/
        [Required]
        public int PhoneNumber { get; set; }

        [Display(Name ="Prime Member")]
        public bool? PrimeCustomer { get; set; }

       
       
    }
}
