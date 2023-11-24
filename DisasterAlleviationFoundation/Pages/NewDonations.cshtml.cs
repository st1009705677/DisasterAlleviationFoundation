using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationFoundation.Pages
{
    public class NewDonationsModel : PageModel
    {
       
    
        public string donorname = "";
        public string date = "";
        public string amount = "";

        public void OnGet()
        {
        }

        public HttpRequest GetRequest()
        {
            return Request;
        }

        public void OnPost(HttpRequest request)
        {
       
            donorname = request.Form["donorname"];
            date = Request.Form["date"];
            amount = Request.Form["amount"];
        }
    }
}