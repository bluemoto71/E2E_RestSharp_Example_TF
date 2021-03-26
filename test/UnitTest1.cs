using System;
using System.Collections.Generic;
using Dynamitey.DynamicObjects;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp; // added
using RestSharp.Serialization.Json;

namespace E2E_RestSharp_Example_TF
{
    [TestFixture]
    public class UnitTest1
    {

        [Test]
        public void TestMethod1()
        {

            //var client = new RestClient("https://api.trello.com");
            var client = new RestClient("https://api.zippopotam.us/");


            // https://api.zippopotam.us/us/90210
            var request = new RestRequest("us/{zipcode}", Method.GET);
            request.AddUrlSegment("zipcode", 90210);

            var response = client.Execute(request);

            /*
            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);

            var result = output["post code"];

            Assert.That(result, Is.EqualTo("90210"), "Post code found");
            */

            JObject obs = JObject.Parse(response.Content);

            Assert.That(obs["post code"].ToString(), Is.EqualTo("90210"), "Post code found");

                 
        }
    }
}
