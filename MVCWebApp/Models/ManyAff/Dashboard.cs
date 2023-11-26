namespace MVCWebApp.Models.ManyAff
{
    public class Dashboard
    {
        public Dashboard()
        {
            
        }

        public ManyaffClient.Responses.DataCard ViewNum = new();
        public ManyaffClient.Responses.DataCard SubmitFormNum = new();
        public ManyaffClient.Responses.DataCard PaidOrderNum = new();
        public ManyaffClient.Responses.DataCard JoinedCampaign = new();
        public ManyaffClient.Responses.DataCard Commission = new();
        public ManyaffClient.Responses.DataCard ValidCommission = new();
        public ManyaffClient.Responses.DataCard HoldCommission = new();
        public ManyaffClient.Responses.DataCard CancelCommission = new();
        public ManyaffClient.Responses.DataCard PaidCommission = new();
        public ManyaffClient.Responses.DataCard RemainingPaidCommission = new();
    }
}
