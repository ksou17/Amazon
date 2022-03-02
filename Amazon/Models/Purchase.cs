using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int DonationId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }
    }
}
