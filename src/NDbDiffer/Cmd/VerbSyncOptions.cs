using CommandLine;

namespace NDbDiffer.Cmd
{
    [Verb("sync", HelpText = "Synchronizes the source database to a destination database.")]
    public class VerbSyncOptions : VerbDatabaseBase
    {

    }
}
