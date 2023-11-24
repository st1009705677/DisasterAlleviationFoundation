using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using DisasterAlleviationFoundation.Pages.InformationPublic;

namespace DisasterAlleviationFoundation.Pages
{
    public class CaptureNewGoodsDonationsModel : PageModel
    {
        public GoodsDonationInfo goodsDonationsInfo = new GoodsDonationInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            goodsDonationsInfo.DonorName = Request.Form["donorname"];
            goodsDonationsInfo.Description = Request.Form["description"];
            goodsDonationsInfo.Categories = Request.Form["categories"];
            goodsDonationsInfo.NumberOfItems = Request.Form["numberofitems"];
            goodsDonationsInfo.Date = Request.Form["date"];


            if (goodsDonationsInfo.DonorName.Length == 0 ||
                goodsDonationsInfo.Description.Length == 0 ||
                goodsDonationsInfo.Categories.Length == 0 ||
                goodsDonationsInfo.NumberOfItems.Length == 0 ||
                goodsDonationsInfo.Date.Length == 0)
            {
                errorMessage = "Please fill in all the fields";
                return;


            }

            try
            {
                String connectionString = "Data Source=julliet.database.windows.net;Initial Catalog=foundation;User ID=julliet;Password=Password@2023;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO NEWGOODSDONATIONS" +
                        "(DonorName, Description, Categories, NumberOfItems, Date) VALUES" +
                        "(@donorname, @description, @categories, @numberofitems, @date;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@donorname", goodsDonationsInfo.DonorName);
                        command.Parameters.AddWithValue("@description", goodsDonationsInfo.Description);
                        command.Parameters.AddWithValue("@numberofitems", goodsDonationsInfo.NumberOfItems);
                        command.Parameters.AddWithValue("@categories", goodsDonationsInfo.Categories);
                        command.Parameters.AddWithValue("@date", goodsDonationsInfo.Date);


                        command.ExecuteNonQuery();
                    }
                }


            }

            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            goodsDonationsInfo.DonorName = "";
            goodsDonationsInfo.Description = "";
            goodsDonationsInfo.NumberOfItems = "";
            goodsDonationsInfo.Categories = "";
            goodsDonationsInfo.Date = "";
            successMessage = "Disaster successfully added";

            Response.Redirect("/NewGoodsDonations/Index");

        }
    }
}