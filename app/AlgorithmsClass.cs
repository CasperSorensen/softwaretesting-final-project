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


        public List<UserModel> DefaultAlgorythm(UserModel UserToMatch)
        {
            List<UserModel> AllUsers = new UserDummies().GetUserDummies();

            int UserYear = int.Parse(UserToMatch.DateOfBirth.ToString("yyyy"));
            var UserZodiacSign = UserToMatch.Zodiac.ToString();

            foreach (var User in AllUsers)
            {
                var compareYear = int.Parse(User.DateOfBirth.ToString("yyyy"));

                if (UserYear == compareYear)
                {
                    PotentialMatches.Add(User);


                    foreach (var NarrowedDownUser in PotentialMatches)
                    {
                        var CompareSign = NarrowedDownUser.Zodiac.ToString();
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
