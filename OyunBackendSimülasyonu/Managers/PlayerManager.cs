using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackendSimülasyonu
{
   public class PlayerManager:IPlayerService
    {
        public int Verify(Player player)
        {
            EDevlet eDevlet=new EDevlet();
            eDevlet.Ad = "Tuna";
            eDevlet.DogumTarihi = "13.05.1998";
            eDevlet.Soyad = "Kaya";
            eDevlet.Tc = "11111111111";

            if (player.PlayerTc==eDevlet.Tc && player.PlayerFirstName==eDevlet.Ad && player.PlayerLastName==eDevlet.Soyad && player.PlayerBirthTime==eDevlet.DogumTarihi)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public void Add(Player player)
        {
            if (Verify(player)==1)
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("hesap hatası");
            }
        }

        public void Update(Player player)
        {
            if (Verify(player) == 1)
            {
                Console.WriteLine("Oyuncu Güncellendi");
            }
            else
            {
                Console.WriteLine("hesap hatası");
            }
        }

        public void Delete(Player player)
        {
            if (Verify(player) == 1)
            {
                Console.WriteLine("Oyuncu Silindi");
            }
            else
            {
                Console.WriteLine("hesap hatası");
            }
        }

        


    }
}
