using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static chURL.Program;

namespace chURL
{
    internal class HttpRequestManager
    {
        private Program.Properties ProgramProperties;
        private ILogger logger;

        public HttpRequestManager(Program.Properties programProperties)
        {
            ProgramProperties = programProperties;
            logger = ProgramProperties.Logger;
        }

        public void Execute()
        {
            var api = new RestCall(ProgramProperties);
            var task = api.Call(ProgramProperties.Options.URL);
            var returned = task.Wait(ProgramProperties.Options.TimeOut);
            if (!returned)
            {
                ProgramProperties.Logger.LogError("API Call Request timed out.");
            }

            // Start Here: The returned result of the HTTP request.
            ProgramProperties.Logger.LogInformation(task.Result.JSON);
        }

    }
}
