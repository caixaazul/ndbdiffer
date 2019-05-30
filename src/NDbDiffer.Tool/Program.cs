using System;
using CommandLine;
using NDbDiffer.Infrastructure.Cmd;

namespace NDbDiffer.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = Parser.Default.ParseArguments<CommandLineOptions>(args)
                   .WithParsed<CommandLineOptions>(o =>
                   {
                       Console.WriteLine("Parsed...");
                   });
        }
    }
}
