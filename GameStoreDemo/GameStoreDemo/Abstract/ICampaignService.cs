using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Update(Campaign campaign);
        public void Delete(Campaign campaign);
    }
}
