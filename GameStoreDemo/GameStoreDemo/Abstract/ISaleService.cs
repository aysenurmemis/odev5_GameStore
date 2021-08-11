using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    interface ISaleService
    {
        public void Sale(Player player, Game game, Campaign campaign);
    }
}
