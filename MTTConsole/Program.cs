using System;

namespace MTTConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsumeEventSync objsync = new ConsumeEventSync();

            var apiCall = "http://localhost:53590/api/Products";
            Console.WriteLine(Environment.NewLine + "Get all products..."+ Environment.NewLine);
            objsync.GetAllEventData(apiCall);


            apiCall = "http://localhost:53590/api/products/GetFeaturedProducts/1";
            Console.WriteLine(Environment.NewLine + "Get  Featured Products..." + Environment.NewLine);
            objsync.GetAllEventData(apiCall);

            string[] categories = { "Electronics", "Fitness", "Garden", "Home","Toys" };
            
             
            foreach (string value in categories)
            {
                Console.WriteLine(Environment.NewLine + "Get products by category ..."+ value + " " + Environment.NewLine);
               
                apiCall = "http://localhost:53590/api/products/GetByCategory/" + value;
                objsync.GetAllEventData(apiCall);

            }

        }
    }
}
