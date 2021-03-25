using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp; // added

namespace E2E_RestSharp_Example_TF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //var client = new RestClient("https://api.trello.com");
            var client = new RestClient("https://api.zippopotam.us/");


            // https://api.zippopotam.us/us/90210
            var request = new RestRequest("us/{zipcode}", Method.GET);
            request.AddUrlSegment("zipcode", 90210);

            var content = client.Execute(request).Content;
        }
    }
}
