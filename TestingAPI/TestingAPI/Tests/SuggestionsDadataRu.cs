using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace TestingAPI
{
    
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    class SuggestionsDadataRu
    {
        private string BASE_URL = "https://suggestions.dadata.ru/suggestions/api/4_1/rs/suggest/fio";

        [Test, Description("Check search query by parameters")]
        public void AddHeaderTest()
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.POST);
            JObject jObjectbody = new JObject();
            jObjectbody.Add("query", "Виктор Иван");
            jObjectbody.Add("count", 7);
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            request.AddHeader("Content-Type", " application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddHeader("Authorization", "Token de5bec7a0b7afa2701a62e4ef43053457b73810b");
            var response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "HttpStatusCode isn't OK");
        }
    }
}
