using CommandLine;
using CommandLine.Text;

namespace KuduConsole
{
    public class KuduOptions : CommandLineOptionsBase
    {
        [Option("s", "Scm", Required = true, HelpText = "SCM Url")]
        public string Scm { get; set; }

        [Option("u", "User", Required = true, HelpText = "Publishing Username")]
        public string Username { get; set; }

        [Option("p", "Pass", Required = true, HelpText = "Publishing Password")]
        public string Password { get; set; }

        [Option("c", "Command", Required = true, HelpText = "Command for the Kudu REST API")]
        public string Command { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}