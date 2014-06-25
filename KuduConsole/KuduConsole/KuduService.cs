using System;
using System.Text;
using System.Threading.Tasks;
using KuduConsole.Rest;
using Refit;

namespace KuduConsole
{
    public class KuduService
    {
        private readonly string _scmUrl;
        private readonly string _username;
        private readonly string _password;
        private readonly string _command;

        public KuduService(string scmUrl, string username, string password, string command)
        {
            _scmUrl = scmUrl.Trim(' ');
            _username = username.Trim(' ');
            _password = password.Trim(' ');
            _command = command.Trim(' ');
        }

        public void Run()
        {
            var authHeader = BasicAuthorizationHeader(_username, _password);
            if (_command.Equals("deployments"))
            {
                Task.Run(() => GetDeployments(authHeader)).Wait();
            }

            if (_command.Equals("scm-info"))
            {
                Task.Run(() => GetScmInfo(authHeader)).Wait();
            }

            if (_command.Equals("extensionsfeed"))
            {
                Task.Run(() => GetSiteExtensions(authHeader)).Wait();
            }
        }

        private async Task GetDeployments(string auth)
        {
            var restService = RestService.For<IDeployment>(_scmUrl);
            var deployments = await restService.GetDeployments(auth);
            foreach (var deployment in deployments)
            {
                Console.WriteLine("Active: " + deployment.active);
                Console.WriteLine("Author: " + deployment.author);
                Console.WriteLine("Author Email: " + deployment.author_email);
                Console.WriteLine("Complete: " + deployment.complete);
                Console.WriteLine("Deployer: " + deployment.deployer);
                Console.WriteLine("End Time: " + deployment.end_timeeeee);
                Console.WriteLine("Id: " + deployment.id);
                Console.WriteLine("Is Readonly: " + deployment.is_readonly);
                Console.WriteLine("Is Temp: " + deployment.is_temp);
                Console.WriteLine("Last Successful End Time: " + deployment.last_success_end_time);
                Console.WriteLine("Log Url: " + deployment.log_url);
                Console.WriteLine("Message: " + deployment.message);
                Console.WriteLine("Progress: " + deployment.progress);
                Console.WriteLine("Received Time: " + deployment.received_time);
            }
        }

        private async Task GetScmInfo(string auth)
        {
            var restService = RestService.For<IScm>(_scmUrl);
            var info = await restService.GetInformation(auth);

            var result = await info.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }

        private async Task GetSiteExtensions(string auth)
        {
            var restService = RestService.For<ISiteExtensions>(_scmUrl);
            var extensions = await restService.GetAllExtensions(auth);

            var result = await extensions.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }

        private string BasicAuthorizationHeader(string username, string password)
        {
            //Create basic auth header
            string authInfo = username + ":" + password;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            return "Basic " + authInfo;
        }
    }
}