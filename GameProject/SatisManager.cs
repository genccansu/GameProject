using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SatisManager : ISatisService
    {
        
      
        public void Satis(Gamer gamer)
        {
            Console.WriteLine("Satış yapıldı." + gamer.Name);
        }
    }
}
