using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using app.Models;

namespace app
{
    public class AlgorithmsClass
    {      

        public Dictionary<UserModel, int> DefaultAlgorithm(UserModel MatchSeeker)
        {
             //Potential Matches will be used in second Part of algorithm
             //result list servers as return object for frontend-storing the user and percentage of "How good of a match they are for one another"- we wil call this number Match Index
             //User Dummies are all curently registered user in our app
             List<UserModel> PotentialMatches = new List<UserModel>();
             Dictionary<UserModel, int> result = new Dictionary<UserModel, int>();
             List<UserModel> AllUsers = new UserDummies().GetUserDummies();

            int MatchSeekerAge = MatchSeeker.Age;
            

            foreach (var RegisteredUser in AllUsers)
            {
                var UserYear = RegisteredUser.Age;

                //if they are same age
                if (MatchSeekerAge == UserYear)
                {
                    //add user with 50% Match Index
                    result.Add(RegisteredUser, 50);

                    //add user to list for futher evaluation
                    PotentialMatches.Add(RegisteredUser);                
                }
                else
                {
                    result.Add(RegisteredUser, 0);
                }
               
            }
            //if they match on age- check if they match on hobbies
            foreach (var NarrowedDownUser in PotentialMatches)
            {
                if (MatchSeeker.Hobby!=null)
                {
                    var MatchSeekerHobbies = MatchSeeker.Hobby.Split(",");
                    var Userhobbies = NarrowedDownUser.Hobby.Split(',');
                    bool haveSharedHobbies = MatchSeekerHobbies.Intersect(Userhobbies).Count() > 0;
                    if (haveSharedHobbies)
                    {
                        //the user is allready in result so we just change his Match Index
                        result[NarrowedDownUser]=100;
                       

                    }
                }           
            }
            return result;
        }

        public Dictionary<UserModel, int> AdvancedAlgorithm(UserModel MatchSeeker)
        {
            //result list servers as return object for frontend-storing the user and percentage of 
            //"How good of a match they are for one another"- we wil call this number Match Index
            //Lists for matches on different values are created
            //User Dummies are all curently registered user in our app
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
                    //If both the matchseeker and user don't match gender
                    //add user to the result with 0 match index
                    result.Add(RegisteredUser, 0);
                }
            }
            //We wil use gender interest as a main factor in this algorithm
            foreach (var match in SameGenderMatches)
            {
              
                bool isInHeightMatches = SameHeightMatches.Contains(match);
                bool isInzodiacMatches = SameSignMatches.Contains(match);
                //lets check if they match on all values
                //otherwise check if they match at least on one value
                if (isInHeightMatches&&isInzodiacMatches)
                {
                    result.Add(match, 100);
                }
                else if (isInHeightMatches || isInzodiacMatches)
                {
                    //if the user is allready in the list change his Match Index
                    if (result.ContainsKey(match))
                    {
                        result[match] = 50;

                    }
                    else
                    {
                        result.Add(match, 50);
                    }
                }
            }
          
            return result;
        }


        }
}
