using GameStoreDemo.Abstract;
using GameStoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concretes
{
    class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager()
        {

        }

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }


        public void add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " adlı kullanıcı sisteme kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Girilen bilgilere ait kullanıcı bulunmamaktadır.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı oyuncu sistemden silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı oyuncu bilgieri güncellendi.");
        }
    }
}
