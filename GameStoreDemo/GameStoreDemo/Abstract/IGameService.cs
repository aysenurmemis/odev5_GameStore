﻿using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    interface IGameService
    {
        public void Add(Game game);
        public void Update(Game game);
        public void Delete(Game game);
    }
}
