using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace DemoBackendAutomation.StepDefinitions
{
    [Binding]
    public sealed class GetStepDefinitions
    {

        [Given(@"I have a endpoint /get")]
        public static async Task GivenIHaveAEndpointGetAsync()
        {

            //var client = new restclient("https://testapi.jasonwatmore.com");
            //var request = new restrequest("products/1");
            //var response = client.executeget(request);
            //console.writeline(response.statuscode);
            //assert.istrue(response.statusdescription.equals("ok"));

            var client = new RestClient("http://petstore.swagger.io");
            var request = new RestRequest("v2/store/inventory");
            var response = client.ExecuteGet(request);
            Console.WriteLine(response.StatusCode);
            Assert.True(response.StatusDescription.Equals("OK"));

        }
    }
}