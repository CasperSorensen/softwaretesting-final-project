using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;

namespace app
{
    public class AlgorithmsClass
    {      

        public Dictionary<UserModel, int> DefaultAlgorithm(UserModel MatchSeeker)
        {
             List<UserModel> PotentialMatches = new List<UserModel>();
              Dictionary<UserModel, int> result = new Dictionary<UserModel, int>();
             List<UserModel> AllUsers = new UserDummies().GetUserDummies();

            int MatchSeekerAge = MatchSeeker.Age;
            

            foreach (var RegisteredUser in AllUsers)
            {
                var UserYear = RegisteredUser.Age;

                if (MatchSeekerAge == UserYear)
                {
                    result.Add(RegisteredUser, 50);
                    PotentialMatches.Add(RegisteredUser);                
                }
                else
                {
                    result.Add(RegisteredUser, 0);
                }
               
            }
            foreach (var NarrowedDownUser in PotentialMatches)
            {
                var MatchSeekerHobbies = MatchSeeker.Hobby.Split(",");
                var Userhobbies = NarrowedDownUser.Hobby.Split(',');
                bool haveSharedHobbies = MatchSeekerHobbies.Intersect(Userhobbies).Count() > 0;
                if (haveSharedHobbies)
                {
                    
                        result.Remove(NarrowedDownUser);
                        result.Add(NarrowedDownUser, 100);
                     
                   
                }               
            }
            return result;
        }

        public Dictionary<UserModel, int> AdvancedAlgorithm(UserModel MatchSeeker)
        {
            Dictionary<UserModel, int> result = new Dictionary<UserModel, int>();
            List<UserModel> SameGenderMatches = new List<UserModel>();
            List<UserModel> SameHeightMatches = new List<UserModel>();
            List<UserModel> SameSignMatches = new List<UserModel>();

            List<UserModel> AllUsers = new UserDummies().GetUserDummies();

            foreach (var RegisteredUser in AllUsers)
            {
                if (RegisteredUser.Gender==MatchSeeker.Gender)
                {
                    SameGenderMatches.Add(RegisteredUser);
                }
                if(RegisteredUser.Height==MatchSeeker.Height)
                {
                    SameHeightMatches.Add(RegisteredUser);
                }
                if (RegisteredUser.Zodiac == MatchSeeker.Zodiac)
                {
                    SameSignMatches.Add(RegisteredUser);
                }
                else
                {
                    result.Add(RegisteredUser, 0);
                }
            }
            foreach (var match in SameGenderMatches)
            {
                bool isInHeightMatches = SameHeightMatches.Contains(match);
                bool isInzodiacMatches = SameSignMatches.Contains(match);
                if (isInHeightMatches&&isInzodiacMatches)
                {
                    result.Add(match, 100);
                }
                else if (isInHeightMatches || isInzodiacMatches)
                {
                    if (result.ContainsKey(match))
                    {
                        result[match] = 60;

                    }
                    else
                    {
                        result.Add(match, 60);
                    }
                }
            }

            
            return result;
        }


        }
}
