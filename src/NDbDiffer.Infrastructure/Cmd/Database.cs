namespace NDbDiffer.Infrastructure.Cmd
{
    public class Database
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UseWindowsAuthentication { get; set; } = false;
    }
}