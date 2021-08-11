using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concretes
{
    class SaleManager : ISaleService
    {
        public void Sale(Player player, Game game, Campaign campaign)
        {
            double afterPrice = game.GamePrice - (game.GamePrice * campaign.CampaignDiscount / 100);

            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı kişiye " + 
                game.GameName + " oyunu " + afterPrice + " indirimli fiyata satıldı." );
        }
    }
}
