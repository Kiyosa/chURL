using Microsoft.Extensions.Logging;
using System.Net;

namespace chURL
{
    class HttpResult(HttpStatusCode status, string json)
    {
        public HttpStatusCode Status = status;
        public string JSON = json;
    }

    internal class RestCall
    {
        private Program.Properties _programProperties;
        private string _method;

        public RestCall(Program.Properties theProgramProperties, string defaultMethod = "GET")
        {
            _programProperties = theProgramProperties;
            _method = defaultMethod;
        }

        public string Method { get => _method; set => _method = value; }

        public async Task<HttpResult> Call(string url)
        {
            HttpResult result = new(HttpStatusCode.RequestTimeout, string.Empty);
            try
            {
                HttpClient httpClient = new();
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("User-Agent", "OBEDS.chURL");

                var request = httpClient.GetAsync(url);
                var returned = request.Wait(_programProperties.Options.TimeOut);
                if (!returned)
                {
                    _programProperties.Logger.LogError($"Request time out. [{_programProperties.Options.TimeOut}]");
                }
                result.Status = request.Result.StatusCode;
                if (result.Status != HttpStatusCode.OK)
                {
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
    }
}
