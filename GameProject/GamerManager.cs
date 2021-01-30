using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public  GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Eklendi.");
            } else
            {
                Console.WriteLine("Doğrulama Başarısız.");
            }
           
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi.");
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi.");
        }
    }
}
