using ManyaffClient.Responses;
using MVCWebApp.Models.ManyAff;
using System.Text.Json;

namespace MVCWebApp.Models
{
    public class PublisherViewModel
    {
        private readonly ManyaffClient.ManyaffClient manyaffClient = new();
        private HttpClient httpClient = new();

        public List<ManyaffClient.User> Users { get; set; } = new();
        public PublisherViewModel()
        {
            Users =
                [
                    new ManyaffClient.User { Email = "pub1@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub2@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub3@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub4@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub5@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub6@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub7@gmail.com", Password = "123456" },
                    new ManyaffClient.User { Email = "pub8@gmail.com", Password = "123456" },
                ];
        }

        public DateTime StartDate = DateTime.Now;
        public DateTime EndDate = DateTime.Now;

        public List<UserDashboard> UserDashboards { get; set; } = new();

        public async Task GetUserDashboard()
        {
            UserDashboards.Clear();

            foreach (ManyaffClient.User user in Users)
            {
                DashboardReponse dashboardReponse = await manyaffClient.GetUserDashboard(user, StartDate, EndDate);
                DataCard dataCard = dashboardReponse.Data.DataCard[0];
                Dashboard dashboard = new()
                {
                    ViewNum = dashboardReponse.Data.DataCard[0],
                    SubmitFormNum = dashboardReponse.Data.DataCard[1],
                    PaidOrderNum = dashboardReponse.Data.DataCard[2],
                    JoinedCampaign = dashboardReponse.Data.DataCard[3],
                    Commission = dashboardReponse.Data.DataCard[4],
                    ValidCommission = dashboardReponse.Data.DataCard[5],
                    HoldCommission = dashboardReponse.Data.DataCard[6],
                    CancelCommission = dashboardReponse.Data.DataCard[7],
                    PaidCommission = dashboardReponse.Data.DataCard[8],
                    RemainingPaidCommission = dashboardReponse.Data.DataCard[9]
                };

                UserDashboard userDashboard = new()
                {
                    Email = user.Email,
                    Password = user.Password,
                    Dashboard = dashboard
                };

                UserDashboards.Add(userDashboard);
            }

            string a = "a";
            //return UserDashboards;
        }

    }
}
