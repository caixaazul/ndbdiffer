using System;
using System.Collections.Generic;
using CommandLine;

namespace NDbDiffer.Infrastructure.Cmd
{
    public class CommandLineOptions
    {
        [Option('m', "mode", Required = true, HelpText = "Execution mode: Extract, Sync.")]
        public ExecutionMode InputFiles { get; set; }

        [Option('s', "source", Required = true, HelpText = "Execution mode: Extract, Sync.")]
        public Database Source { get; set; }
    }
}
