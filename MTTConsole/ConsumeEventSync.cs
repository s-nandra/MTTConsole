using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MTTConsole
{
    public class ConsumeEventSync
    {
        public void GetAllEventData(string apiCall) //Get All Events Records  
        {
            
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                //var result = client.DownloadString("http://localhost:53590/api/Products"); //URI  
                var result = client.DownloadString(apiCall); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
