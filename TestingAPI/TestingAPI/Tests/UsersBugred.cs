using System.Net;
using Newtonsoft.Json.Linq;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;

namespace TestingAPI
{

    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class UsersBugred
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse response;
        private JObject jObjectbody;
        private const string BASE_URL = "http://users.bugred.ru/tasks/rest/";

        [SetUp]
        public void SetupTest()
        {
            client = new RestClient(BASE_URL);
            jObjectbody = new JObject();
        }

        [Test, Description("Checking status code at method getCompany")]
        public void StatusCodeTest()
        {
            request = new RestRequest("getcompany", Method.POST);
            jObjectbody.Add("id_company", "789");
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "HttpStatusCode isn't OK");
        }

        [Test, Description("Checking content type at method getCompany")]
        public void ContentTypeTest()
        {
            request = new RestRequest("getcompany", Method.POST);
            IRestResponse response = client.Execute(request);
            jObjectbody.Add("id_company", "789");
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            Assert.That(response.ContentType, Is.EqualTo("application/json"), "ContentType isn't application/json");
        }

        [Test, Description("Checking company type at method getCompany")]
        public void CompanyTypeTest()
        {      
            request = new RestRequest("getcompany", Method.POST);
            jObjectbody.Add("id_company", "20");
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Company company = new JsonDeserializer().Deserialize<Company>(response);
            Assert.That(company.Type, Is.EqualTo("ИП"), "Type isn't 'ИП'");
            Assert.That(company.Name, Is.EqualTo("Иванов 6"), "Name isn't 'Иванов 6'");
        }

        [Test, Description("Checking that the user is registered")]
        public void DoRegisterTest()
        {
            var request = new RestRequest("doregister", Method.POST);
            JObject jObjectbody = new JObject();
            jObjectbody.Add("email", "nauraynqq@rr.ru");
            jObjectbody.Add("name", "gurealuri");
            jObjectbody.Add("password", "Password@123");
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            var response = client.Execute(request);
            User user = new JsonDeserializer().Deserialize<User>(response);
           // Assert.That(user.Type, Is.EqualTo("error"), "type is not error");
            Assert.That(user.Message, Is.EqualTo(" email nauraynqq@rr.ru уже есть в базе"), "this isn't error message");
        }      
    }
}
