using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationFoundation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public static string? DonorName { get; internal set; }
        public static string? Description { get; internal set; }
        public int NumberOfItems { get; internal set; }
        public static string? Categories { get; internal set; }
        public DateOnly Date { get; internal set; }

        public void OnGet()
        {

        }
    }
}