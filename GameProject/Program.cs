using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());


            gamerManager.add(new Gamer
            {
                Id = 1,
                Name = "cansu",
                Surname = "genç",
                BirtDay = 1998,
                IdentityNumber = 123456

            });

            SatisManager satisManager = new SatisManager();
             satisManager.Satis(new Gamer());

           

        }
    }
}
