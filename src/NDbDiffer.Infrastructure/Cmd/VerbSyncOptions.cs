using CommandLine;

namespace NDbDiffer.Infrastructure.Cmd
{
    [Verb("sync", HelpText = "Synchronizes the source database to a destination database.")]
    public class VerbSyncOptions
    {
        [Option("source.server", Required = true, HelpText = "Source Server name.")]
        public string SourceServerName { get; set; }

        [Option("source.database", Required = true, HelpText = "Source database name.")]
        public string SourceDatabaseName { get; set; }

        [Option("source.user", Required = false, HelpText = "Source user name.")]
        public string SourceUserName { get; set; }

        [Option("source.password", Required = false, HelpText = "Source user's password.")]
        public string SourcePassword { get; set; }

        [Option("source.useWindowsAuthentication", Required = false, HelpText = "Indicates if the connection will be made using Windows Authentication.")]
        public bool SourceUseWindowsAuthentication { get; set; } = false;

        [Option("destination.server", Required = true, HelpText = "Destination Server name.")]
        public string DestinationServerName { get; set; }

        [Option("destination.database", Required = true, HelpText = "Destination database name.")]
        public string DestinationDatabaseName { get; set; }

        [Option("destination.user", Required = false, HelpText = "Destination user name.")]
        public string DestinationUserName { get; set; }

        [Option("destination.password", Required = false, HelpText = "Destination user's password.")]
        public string DestinationPassword { get; set; }

        [Option("destination.useWindowsAuthentication", Required = false, HelpText = "Indicates if the connection will be made using Windows Authentication.")]
        public bool DestinationUseWindowsAuthentication { get; set; } = false;

    }
}
