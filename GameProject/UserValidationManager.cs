using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirtDay==1998 && gamer.Name=="cansu"&& gamer.Surname=="genç"&& gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
