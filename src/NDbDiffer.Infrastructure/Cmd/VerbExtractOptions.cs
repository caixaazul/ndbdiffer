using System;
using System.Collections.Generic;
using CommandLine;

namespace NDbDiffer.Infrastructure.Cmd
{
    [Verb("extract", HelpText = "Extracts the schema of the database and generates the script files into a target folder")]
    public class VerbExtractOptions
    {
        [Option('s', "server", Required = true, HelpText = "Server name.")]
        public string ServerName { get; set; }

        [Option('d', "database", Required = true, HelpText = "database name.")]
        public string DatabaseName { get; set; }

        [Option('u', "user", Required = false, HelpText = "user name.")]
        public string UserName { get; set; }

        [Option('p', "password", Required = false, HelpText = "user's password.")]
        public string Password { get; set; }

        [Option('f', "folder", Required = true, HelpText = "user's password.")]
        public string TargetFolder {get;set;}
    }
}
