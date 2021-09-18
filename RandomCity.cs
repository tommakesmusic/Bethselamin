using System;
namespace Bethselamin.Models
{
    public class RandomCity
    {

        public static string getCity()
        {
            Random rnd = new Random();

            string[] cities = { "44418/", "560743/", "19344/", "2295420/", "2295412/" };

            
            string city = (string)cities.GetValue(rnd.Next(0, 4));

            return city;
        }
    }
}
