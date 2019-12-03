using System;
using System.Collections.Generic;

namespace app.Models
{
    public class UserDummies
    {
        public List<UserModel> userDummies = new List<UserModel>();
        //one line code instance in client 
        //"List<UserModel> DummieList = new UserDummies().GetUserDummies();"
        public List<UserModel> GetUserDummies(){
            //----------- > Female Dummies
            UserModel DummieUser01= new UserModel()
            {
                Name = "Birgitte",
                Gender= Gender.Other,
                DateOfBirth = new DateTime(1992,4,24),
                Height = 179,
                Hobby = "Trains",
                Algorithm = true,
                Zodiac = ZodiacSign.Taurus
            };
            UserModel DummieUser02= new UserModel()
            {
                Name = "Charlotte",
                Gender= Gender.Female,
                DateOfBirth = new DateTime(1995,3,8),
                Height = 159,
                Hobby = "Architecture",
                Algorithm = true,
                Zodiac = ZodiacSign.Pisces
            };
            UserModel DummieUser03= new UserModel()
            {
                Name = "Freja",
                Gender= Gender.Female,
                DateOfBirth = new DateTime(1996,12,29),
                Height = 179,
                Hobby = "Programming",
                Algorithm = true,
                Zodiac = ZodiacSign.Capricorn
            };
            UserModel DummieUser04= new UserModel()
            {
                Name = "Sarah",
                Gender= Gender.Female,
                DateOfBirth = new DateTime(1989,7,11),
                Height = 160,
                Hobby = "Pets",
                Algorithm = true,
                Zodiac = ZodiacSign.Cancer
            };
            UserModel DummieUser05= new UserModel()
            {
                Name = "Signe",
                Gender= Gender.Female,
                DateOfBirth = new DateTime(1992,11,7),
                Height = 162,
                Hobby = "Gaming",
                Algorithm = true,
                Zodiac = ZodiacSign.Scorpio
            };
            //----------- > Male Dummies
            UserModel DummieUser06= new UserModel()
            {
                Name = "Laurits",
                Gender= Gender.Male,
                DateOfBirth = new DateTime(1988,7,12),
                Height = 186,
                Hobby = "Pets",
                Algorithm = true,
                Zodiac = ZodiacSign.Cancer
            };
            UserModel DummieUser07= new UserModel()
            {
                Name = "Hjalte",
                Gender= Gender.Male,
                DateOfBirth = new DateTime(1990,10,2),
                Height = 179,
                Hobby = "Programming",
                Algorithm = true,
                Zodiac = ZodiacSign.Virgo
            };
            UserModel DummieUser08= new UserModel()
            {
                Name = "Jens",
                Gender= Gender.Male,
                DateOfBirth = new DateTime(1990,11,19),
                Height = 182,
                Hobby = "Gaming",
                Algorithm = true,
                Zodiac = ZodiacSign.Scorpio
            };
            UserModel DummieUser09= new UserModel()
            {
                Name = "Jesper",
                Gender= Gender.Male,
                DateOfBirth = new DateTime(1991,7,19),
                Height = 180,
                Hobby = "Pets",
                Algorithm = true,
                Zodiac = ZodiacSign.Cancer
            };
            UserModel DummieUser10= new UserModel()
            {
                Name = "Tom",
                Gender= Gender.Other,
                DateOfBirth = new DateTime(1998,7,17),
                Height = 179,
                Hobby = "Tennis",
                Algorithm = true,
                Zodiac = ZodiacSign.Cancer
            };

            userDummies.Add(DummieUser01);
            userDummies.Add(DummieUser02);
            userDummies.Add(DummieUser03);
            userDummies.Add(DummieUser04);
            userDummies.Add(DummieUser05);
            userDummies.Add(DummieUser06);
            userDummies.Add(DummieUser07);
            userDummies.Add(DummieUser08);
            userDummies.Add(DummieUser09);
            userDummies.Add(DummieUser10);



            return userDummies;
        }

    }
}