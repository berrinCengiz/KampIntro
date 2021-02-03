using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", IdentityNumber = 12345, BirthYear = 1985 });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaign();
            campaignManager.CampaignUpdate();
            campaignManager.CampaignDelete();

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Order(new Gamer { Id = 2, FirstName = "Berrin", LastName = "Cengiz", IdentityNumber = 123456789, BirthYear = 1991 });
        
        }
    }
}
