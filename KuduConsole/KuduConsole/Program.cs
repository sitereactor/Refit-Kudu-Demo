using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;

namespace KuduConsole
{
    class Program
    {
        static int Main(string[] args)
        {
            var options = new KuduOptions();
            var exitCode = 0;

            var argumentList = new List<string>();
            if (args.Any() == false)
            {
                Console.WriteLine("Input please");
                Console.WriteLine("Base Kudu Url:");
                string scm = Console.ReadLine();
                argumentList.Add(string.Concat("-s ", scm));

                Console.WriteLine("Kudu username:");
                string username = Console.ReadLine();
                argumentList.Add(string.Concat("-u ", username));

                Console.WriteLine("Kudu password:");
                string password = Console.ReadLine();
                argumentList.Add(string.Concat("-p ", password));

                Console.WriteLine("Kudu command (deployments, scm-info or extensionsfeed):");
                string command = Console.ReadLine();
                argumentList.Add(string.Concat("-c ", command));
            }

            var arguments = args.Any() ? args : argumentList.ToArray();

            try
            {
                var parser = new CommandLineParser();
                if (parser.ParseArguments(arguments, options))
                {
                    var service = new KuduService(options.Scm, options.Username, options.Password, options.Command);
                    service.Run();
                }
                else
                {
                    throw new InvalidOperationException("Failed to parse arguments");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
                exitCode = 1;
            }

            return exitCode;
        }
    }
}
