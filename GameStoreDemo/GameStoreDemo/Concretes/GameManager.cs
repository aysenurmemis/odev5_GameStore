using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concretes 
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.\n" + "Oyunun fiyatı :  " + game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silinmiştir.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellenmştir.");
        }
    }
}
