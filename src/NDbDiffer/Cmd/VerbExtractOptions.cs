using CommandLine;

namespace NDbDiffer.Cmd
{
    [Verb("extract", HelpText = "Extracts the schema of the database and generates the script files into a target folder")]
    public class VerbExtractOptions
    {
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
    }
}
