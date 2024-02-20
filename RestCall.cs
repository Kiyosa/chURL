using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;

namespace chURL
{
    class HttpResult(HttpStatusCode status, string json)
    {
        public HttpStatusCode Status = status;
        public string JSON = json;
    }

    internal class RestCall(Program.Properties theProgramProperties, string defaultMethod = "GET")
    {
        private Program.Properties _programProperties = theProgramProperties;
        private string _method = defaultMethod;

        public string Method { get => _method; set => _method = value; }

        public async Task<HttpResult> Call(string url, HttpContent? content = null)
        {
            HttpResult result = new(HttpStatusCode.RequestTimeout, string.Empty);
            try
            {
                using HttpClient httpClient = new();
                httpClient.DefaultRequestHeaders.Add("User-Agent", "OBEDS.chURL");

                using Task<HttpResponseMessage> request = CreateHttpRequest(httpClient, url, content);
                var returned = request.Wait(_programProperties.Options.TimeOut);
                if (!returned)
                {
                    _programProperties.Logger.LogError($"Request time out. [{_programProperties.Options.TimeOut}]");
                }
                result.Status = request.Result.StatusCode;
                if (result.Status != HttpStatusCode.OK)
                {
                    throw new Exception($"HTTP Error {result.Status}");
                }

                var response = await request.Result.Content.ReadAsStringAsync();
                if (response?.Length > 0)
                {
                    result.JSON = response;
                }
            }
            catch (Exception ex)
            {
                _programProperties.Logger.LogCritical($"{ex}");
            }
            return result;
        }

        Task<HttpResponseMessage> CreateHttpRequest(HttpClient httpClient, string url, HttpContent? content)
        {
            // Add authentication headers if available/required.
            switch (_programProperties.Options.Authorization)
            {
                case Program.AuthType.None:
                    break;

                case Program.AuthType.Basic:
                    var authenticationString = $"{_programProperties.Options.AuthUser}:{_programProperties.Options.AuthPassword}";
                    var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {base64EncodedAuthenticationString}");
                    break;

                case Program.AuthType.ApiKey:
                    httpClient.DefaultRequestHeaders.Add("api-key", _programProperties.Options.ApiKey);
                    break;

                case Program.AuthType.OAuth2:
                    throw new NotImplementedException("AuthType.OAuth2");

                case Program.AuthType.NTLM:
                    throw new NotImplementedException("AuthType.NTLM");

                default:
                    throw new ArgumentException($"Invalid Authorization type: {_programProperties.Options.Authorization}");
            }

            // Build an appropriate Task to wait for a response to.
            switch (_method)
            {
                case "HEAD":
                    return httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

                case "GET":
                    httpClient.DefaultRequestHeaders.Add("Accept", _programProperties.Options.Accept);
                    return httpClient.GetAsync(url);

                case "POST":
                    httpClient.DefaultRequestHeaders.Add("Accept", _programProperties.Options.Accept);
                    return httpClient.PostAsync(url, content);

                case "PUT":
                    httpClient.DefaultRequestHeaders.Add("Accept", _programProperties.Options.Accept);
                    return httpClient.PutAsync(url, content);

                case "DELETE":
                    return httpClient.DeleteAsync(url);

                default:
                    throw new ArgumentException($"Invalid HTTP Method '{_method}'");
            }
        }
    }
}
