using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationFoundation.Pages.InformationPublic
{
    public class IndexModel : PageModel
    {
        public class CaptureNewMonetary
        {
            public decimal Amount { get; set; }
        }

        public class CatureNewGoodsDonations
        {
            public int Quantity { get; set; }
        }

        public class CaptureNewDisaster
        {
            public string? Name { get; set; }
            public decimal AllocatedMoney { get; set; }
            public int AllocatedGoods { get; set; }
        }
        public void OnGet()
        {
        }
    }
}
