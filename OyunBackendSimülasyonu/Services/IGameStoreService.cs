using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackendSimülasyonu
{
    interface IGameStoreService
    {
        public void Buy(Player player);
        public void Refund(Player player );

    }
}
