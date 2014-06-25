namespace KuduConsole.Models
{
    public class DeploymentLog
    {
        public string log_time { get; set; }
        public string id { get; set; }
        public string message { get; set; }
        public int type { get; set; }
        public string details_url { get; set; } 
    }
}