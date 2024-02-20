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
    {

        public void Execute()
        {
            var api = new RestCall(ProgramProperties);
            var task = api.Call(ProgramProperties.Options.URL);
            var returned = task.Wait(ProgramProperties.Options.TimeOut);
            if (!returned)
            {
            }

            // Start Here: The returned result of the HTTP request.
        }

    }
}
