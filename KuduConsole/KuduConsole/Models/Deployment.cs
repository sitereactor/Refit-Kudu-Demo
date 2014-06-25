namespace KuduConsole.Models
{
    public class Deployment
    {
        public string id { get; set; }
        public int status { get; set; }
        public string status_text { get; set; }
        public string author_email { get; set; }
        public string author { get; set; }
        public string deployer { get; set; }
        public string message { get; set; }
        public string progress { get; set; }
        public string received_time { get; set; }
        public string start_time { get; set; }
        public string end_timeeeee { get; set; }
        public string last_success_end_time { get; set; }
        public bool complete { get; set; }
        public bool active { get; set; }
        public bool is_temp { get; set; }
        public bool is_readonly { get; set; }
        public string url { get; set; }
        public string log_url { get; set; }
    }
}