using Microsoft.Extensions.Logging;

namespace chURL
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing command line args. /? for usage.");
                return 1;
            }

            return 0;
        }
    }
}
