using System;
namespace Bethselamin.Models
{
    public static class StoreCount
    {
        private static string myCount = "";
        private static string message = "";
        

        public static void SetCount()
        {
            /*
             * 
             */
            //Random rnd = new Random();
            Guid demoGuid = Guid.NewGuid();
            //int blockNumber = rnd.Next(12552, 214089979);
            myCount = demoGuid.ToString();
        }

        public static string GetCount()
        {
            return myCount;
        }

        public static void DecCount()
        {
            
                myCount="";
            
        }

        public static string GetMessage()
        {
            /*if (myCount == 53)
            {
                message = "53 That's my race number!";
            }
            else if (myCount == 4)
            {
                message = "Charley paws is four!";
            }
            else
            {
                message = "";
            }*/
            message = "";
            return message;
        }

    }
}
