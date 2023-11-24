using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DisasterAlleviationFoundation.Models
{
    public class NewDonations
    {
            [Key]
            public string? DonorName { get; set; }
            public int Amount { get; set; }
            public DateTime DateOfDonation { get; set; }
            public string? ItemDesc { get; set; }
            public string? DateOfGoodsDonation { get; set; }
        }
    }

