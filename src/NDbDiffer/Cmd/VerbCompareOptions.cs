using CommandLine;

namespace NDbDiffer.Cmd
{
    [Verb("compare", HelpText = "Compares two databases and generates its differences.")]
    public class VerbCompareOptions : VerbDatabaseBase
    {
    }
}
