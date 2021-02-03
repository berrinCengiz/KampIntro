using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void CampaignDelete()
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void NewCampaign()
        {
            Console.WriteLine("Yeni Kampanya oluşturuldu");
        }
    }
}
