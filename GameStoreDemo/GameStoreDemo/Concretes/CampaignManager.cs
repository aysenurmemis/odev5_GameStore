using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concretes
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya sisteme %" +
                campaign.CampaignDiscount + " indirim oranı ile eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya sistemden silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanyanın indirim oranı güncellenmiştir.");
        }
    }
}
