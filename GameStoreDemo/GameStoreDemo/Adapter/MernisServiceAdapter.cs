using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameStoreDemo.Adapter
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            if (player.Id == 1 && player.FirstName == "Ayşenur" && player.LastName == "Memiş" && 
                player.NationalityId == "123456789" && player.DateOfBirth == 1999)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
