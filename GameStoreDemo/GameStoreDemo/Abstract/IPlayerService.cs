using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    interface IPlayerService
    {
        public void add(Player player);
        public void Update(Player player);
        public void Delete(Player player);
    }
}
