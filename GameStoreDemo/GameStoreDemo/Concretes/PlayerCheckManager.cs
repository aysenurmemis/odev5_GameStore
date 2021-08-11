using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concretes
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
