using System;
using System.Collections.Generic;
using System.Text;
using OyunBackendSimülasyonu.Entity;

namespace OyunBackendSimülasyonu.Managers
{
   public class GameStoreManager:IGameStoreService
    {
        public void Buy(Player player)
        {
            if (player.PlayerBudget==gameStore.GamePrice)
            {
                Console.WriteLine("Oyun Alındı");
                player.GamesPlayerHas = gameStore.GameName;
                player.PlayerBudget = player.PlayerBudget - gameStore.GamePrice;
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye");
            }
        }

        public void Refund(Player player)
        {
            Console.WriteLine("Oyun iade edildi");
            player.GamesPlayerHas = " ";
            player.PlayerBudget = player.PlayerBudget + gameStore.GamePrice;
        }

     GameStore gameStore=new GameStore();
    }
}
