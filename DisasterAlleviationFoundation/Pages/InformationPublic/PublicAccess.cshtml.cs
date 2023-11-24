using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DisasterAlliviationFoundation.Pages
{
    public class PublicAccessModel : PageModel
    {
        public List<ViewAllListsInfo> ListViewAllLists = new List<ViewAllListsInfo>();

        private readonly ILogger<ViewAllListsModel> _logger;

        public PublicAccessModel(ILogger<ViewAllListsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=julliet.database.windows.net;Initial Catalog=foundation;User ID=julliet;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM ViewAllLists";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ViewAllListsInfo viewAllLists = new ViewAllListsInfo();
                                viewAllLists.TotalMonetaryDonations Received = reader.GetString(0);
                                viewAllLists.AllIncomingGoodsDonations = reader.GetString(1);
                                viewAllLists.AllDisasters = reader.GetString(2);

                                ListViewAllLists.Add(viewAllLists);
                                

                            }
                        }
                    }

                }
            }

            catch (Exception)
            {
            }
        }
        public class ViewAllListsInfo
        {
            public string? AllIncomingMonetaryDonations;
            public string? AllIncomingGoodsDonations;
            public string? AllDisasters;
        }
    }
}


