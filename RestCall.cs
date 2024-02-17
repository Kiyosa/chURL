using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using System.Web.Http;
using System.Net;
using System.Text.Json.Nodes;

namespace chURL
{
    class HttpResult(HttpStatusCode status, string json)
    {
        public HttpStatusCode Status = status;
        public string JSON = json;
    }

    internal class RestCall
    {
        private ILogger _logger;
        private HttpClient _httpClient;
        private string _method;
        private HttpStatusCode _httpStatus;

        public RestCall(ILogger theLogger, string defaultMethod = "GET")
        {
            _logger = theLogger;
            _httpClient = new();
            _method = defaultMethod;
            _httpStatus = HttpStatusCode.OK;
        }

        public string Method { get => _method; set => _method = value; }

        public HttpStatusCode Status { get => _httpStatus; }

        public async Task<HttpResult> Call(string url)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "OBEDS.chURL");

            try
            {
                var json = await _httpClient.GetStringAsync(url);
                if (json == null)
                {
                    _logger.LogWarning("Empty JSON response.");
                }
                return new HttpResult(_httpStatus, json ?? string.Empty);
            }
            catch (HttpResponseException httpEx)
            {
                _httpStatus = httpEx.Response.StatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Unexpected exception {ex}");
                _httpStatus = HttpStatusCode.BadRequest;
            }
            return new HttpResult(_httpStatus, string.Empty);
        }
    }
}
