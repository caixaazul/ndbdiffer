using System;
using CommandLine;
using NDbDiffer.Cmd;

namespace NDbDiffer
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = Parser.Default.ParseArguments<VerbExtractOptions, VerbSyncOptions>(args)
                .WithParsed<VerbExtractOptions>(opts => ExecuteExtractVerb(opts))
                .WithParsed<VerbSyncOptions>(opts => ExecuteSyncVerb(opts))
                .WithNotParsed(errs => Console.WriteLine("Not supported options"));
        }

        private static void ExecuteExtractVerb(VerbExtractOptions options)
        {
            Console.WriteLine($"{options.SourceServerName}");
        }

        private static void ExecuteSyncVerb(VerbSyncOptions options)
        {
            Console.WriteLine($"{options.SourceServerName}");
        }
    }
}
