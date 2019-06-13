using CommandLine;

namespace NDbDiffer.Cmd
{
    public abstract class VerbDatabaseBase
    {
        [Option("source.folder", Required = false, HelpText = "Source Folder path.")]
        public string SourceFolder { get; set; }

        [Option("destination.folder", Required = false, HelpText = "Destination Folder path.")]
        public string DestinationFolder { get; set; }

        [Option("source.server", Required = false, HelpText = "Source Server name.")]
        public string SourceServerName { get; set; }

        [Option("source.database", Required = false, HelpText = "Source database name.")]
        public string SourceDatabaseName { get; set; }

        [Option("source.user", Required = false, HelpText = "Source user name.")]
        public string SourceUserName { get; set; }

        [Option("source.password", Required = false, HelpText = "Source user's password.")]
        public string SourcePassword { get; set; }

        [Option("source.useWindowsAuthentication", Required = false, HelpText = "Indicates if the connection will be made using Windows Authentication.")]
        public bool SourceUseWindowsAuthentication { get; set; } = false;

        [Option("destination.server", Required = false, HelpText = "Destination Server name.")]
        public string DestinationServerName { get; set; }

        [Option("destination.database", Required = false, HelpText = "Destination database name.")]
        public string DestinationDatabaseName { get; set; }

        [Option("destination.user", Required = false, HelpText = "Destination user name.")]
        public string DestinationUserName { get; set; }

        [Option("destination.password", Required = false, HelpText = "Destination user's password.")]
        public string DestinationPassword { get; set; }

        [Option("destination.useWindowsAuthentication", Required = false, HelpText = "Indicates if the connection will be made using Windows Authentication.")]
        public bool DestinationUseWindowsAuthentication { get; set; } = false;
    }
}
