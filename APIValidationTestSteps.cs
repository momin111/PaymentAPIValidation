using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PaymentAPIValidation
{
    [Binding]
    public class APIValidationTestSteps
    {
        private readonly ScenarioContext context;
        public APIValidationTestSteps(ScenarioContext context)
        {
            this.context = context;
        }
        [Given(@"I have the following request body:")]
        public void GivenIHaveTheFollowingRequestBody(string requestBodyJson)
        {
            context.Set(requestBodyJson, "Request");
        }

        [When(@"I post this request with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithValidKeyToTheApiAsync(string validAuthKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(validAuthKey, apiUrl);
            try
            {
                context.Set(response.ReasonPhrase, "ResponseReasonPhrase");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with empty '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithEmptyKeyToTheApiAsync(string emptyAuthKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(emptyAuthKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with invalid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithInvalidKeyToTheApiAsync(string invalidAuthKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(invalidAuthKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Austria IBAN with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfAustriaIBANWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForAustriaIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Germany with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfGermanyWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForGermanyIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Switzerland with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfSwitzerlandWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForSwitzerlandIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Finland with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfFinlandWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForFinlandIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Sweden with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfSwedenWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForSwedenIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Norway with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfNorwayWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForNorwayIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of Denmark  with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfDenmarkWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCodeForDenmarkIBAN");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of less than Seven character and invalid IBAN with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfLessThanSevenCharacterAndInvalidIBANWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request of invalid but exactly Seven char IBAN with space character with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestOfInvalidButExactlySevenCharIBANWithSpaceCharacterWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with invalid but exactly Seven char IBAN with no space character with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithInvalidButExactlySevenCharIBANWithNoSpaceCharacterWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with valid but not supported IBAN which contains exactly Thirty Four character  with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithValidButNotSupportedIBANWhichContainsExactlyThirtyFourCharacterWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with valid but not supported IBAN which contains less than Thirty Four character with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithValidButNotSupportedIBANWhichContainsLessThanThirtyFourCharacterWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with Invalid IBAN which contains exactly Thirty Four character with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithInvalidIBANWhichContainsExactlyThirtyFourCharacterWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with invalid and more than Thirty Four char IBAN with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithInvalidAndMoreThanThirtyFourCharIBANWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                context.Set(response.ReasonPhrase, "ResponseReasonPhrase");
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with null or empty IBAN with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithNullOrEmptyIBANWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response = await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
        }
        
        [When(@"I post this request with invalid IBAN with valid '(.*)' key to the '(.*)' api")]
        public async Task WhenIPostThisRequestWithInvalidIBANWithValidKeyToTheApiAsync(string authKey, string apiUrl)
        {
            var response =await GetResponseFromAPIAsync(authKey, apiUrl);
            try
            {

                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                context.Set(responseBody, "ResponseBody");
            }
            catch (Exception e)
            {
                GetException(e);
            }
            }
        
        [Then(@"the result should be  : ""(.*)""")]
        public void ThenTheResultShouldBe(string reasonPhrase)
        {
            Assert.AreEqual(reasonPhrase, context.Get<string>("ResponseReasonPhrase"));
        }
        
        [Then(@"the response body description should include: ""(.*)""")]
        public void ThenTheResponseBodyDescriptionShouldInclude(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"the response body description for invalid JWT token should include : ""(.*)""")]
        public void ThenTheResponseBodyDescriptionForInvalidJWTTokenShouldInclude(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Status Code for IBAN of Austria should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfAustriaShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForAustriaIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Germany should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfGermanyShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForGermanyIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Switzerland should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfSwitzerlandShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForSwitzerlandIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Finland should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfFinlandShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForFinlandIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Sweden should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfSwedenShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForSwedenIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Norway should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfNorwayShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForNorwayIBAN"));
        }
        
        [Then(@"Status Code for IBAN of Denmark should be: \((.*)\)")]
        public void ThenStatusCodeForIBANOfDenmarkShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCodeForDenmarkIBAN"));
        }
        
        [Then(@"Message for In-valid IBAN number less than Seven character should be: ""(.*)""")]
        public void ThenMessageForIn_ValidIBANNumberLessThanSevenCharacterShouldBe(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Message for invalid but exactly Seven char IBAN with space character should be: ""(.*)""")]
        public void ThenMessageForInvalidButExactlySevenCharIBANWithSpaceCharacterShouldBe(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Message for invalid but exactly Seven char IBAN with no space character should be: ""(.*)""")]
        public void ThenMessageForInvalidButExactlySevenCharIBANWithNoSpaceCharacterShouldBe(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Response body for valid but not supported IBAN which contains exactly Thirty Four character  should contain: ""(.*)""")]
        public void ThenResponseBodyForValidButNotSupportedIBANWhichContainsExactlyThirtyFourCharacterShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Response body for valid but not supported IBAN which contains less than Thirty Four character should contain: ""(.*)""")]
        public void ThenResponseBodyForValidButNotSupportedIBANWhichContainsLessThanThirtyFourCharacterShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Response body for Invalid IBAN which contains exactly Thirty Four character should contain: ""(.*)""")]
        public void ThenResponseBodyForInvalidIBANWhichContainsExactlyThirtyFourCharacterShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"The result for invalid and more than Thirty Four char IBAN should be :""(.*)""")]
        public void ThenTheResultForInvalidAndMoreThanThirtyFourCharIBANShouldBe(string reasonPhrase)
        {
            Assert.AreEqual(reasonPhrase, context.Get<string>("ResponseReasonPhrase"));
        }
        
        [Then(@"Response body for invalid and more than Thirty Four char IBAN should contain: ""(.*)""")]
        public void ThenResponseBodyForInvalidAndMoreThanThirtyFourCharIBANShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Response body for null or empty IBAN should contain: ""(.*)""")]
        public void ThenResponseBodyForNullOrEmptyIBANShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }
        
        [Then(@"Response body for invalid IBAN should contain: ""(.*)""")]
        public void ThenResponseBodyForInvalidIBANShouldContain(string responseBody)
        {
            Assert.IsTrue(context.Get<string>("ResponseBody").Contains(responseBody));
        }

        public async Task<HttpResponseMessage> GetResponseFromAPIAsync(string authKey,string apiUrl)
        {
            var requestBody = context.Get<string>("Request");

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl)
            {
                Content = new StringContent(requestBody)
                {
                    Headers =
                    {
                        ContentType= new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            request.Headers.Add("X-Auth-Key", authKey);

            var response = await client.SendAsync(request).ConfigureAwait(false);
            return response;
        }

        public void GetException(Exception ex)
        {
            string filePath = @"C:\Error.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine();

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Message : " + ex.Message);
                    writer.WriteLine("StackTrace : " + ex.StackTrace);

                    ex = ex.InnerException;
                }
            }

        }
    }
}
