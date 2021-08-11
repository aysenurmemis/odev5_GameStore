using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
