using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackendSimülasyonu
{
    interface IPlayerService
    {
        public int Verify(Player player);
        public void Add(Player player);
        public void Update(Player player);
        public void Delete(Player player);

    }
}
