using System;

namespace OyunBackendSimülasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                PlayerFirstName = "Tuna", PlayerLastName = "Kaya", PlayerTc = "11111111111", PlayerBudget = 67000,
                PlayerUserName = "Tuna98",PlayerBirthTime = "13.05.1998"
            };
            PlayerManager playerManager=new PlayerManager();
            
           
            playerManager.Add(player1);
            playerManager.Update(player1);
            playerManager.Delete(player1);

        }
    }
}
