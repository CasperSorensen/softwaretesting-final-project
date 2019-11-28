using System;

namespace app.Models
{
    public enum ZodiacSign
    {
        Scorpio,
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces,

    }

    public class UserModel
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public string Hobby { get; set; }
        public bool Algorithm { get; set; }
        public ZodiacSign Zodiac { get; set; }



    }
}