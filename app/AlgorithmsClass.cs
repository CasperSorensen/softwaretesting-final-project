using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;

namespace app
{
    public class AlgorithmsClass
    {
        public List<UserModel> PotentialMatches = new List<UserModel>();
        public List<UserModel> HighPotentialMatches = new List<UserModel>();


        public List<UserModel> DefaultAlgorithm(UserModel UserToMatch)
        {
            List<UserModel> AllUsers = new UserDummies().GetUserDummies();

            int UserYear = UserToMatch.DateOfBirth.Year;
            var UserZodiacSign = UserToMatch.Zodiac;

            foreach (var User in AllUsers)
            {
                var compareYear = User.DateOfBirth.Year;

                if (UserYear == compareYear)
                {
                    PotentialMatches.Add(User);


                    foreach (var NarrowedDownUser in PotentialMatches)
                    {
                        var CompareSign = NarrowedDownUser.Zodiac;
                        if (UserZodiacSign == CompareSign)
                        {
                            HighPotentialMatches.Add(NarrowedDownUser);
                        }
                    }

                }
               
            }
                     
            return HighPotentialMatches;
        }


    }
}
