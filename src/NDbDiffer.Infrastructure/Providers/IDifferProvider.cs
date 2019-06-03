using System;

namespace NDbDiffer.Infrastructure.Providers
{
    public interface IDifferProvider : IDifferExtractProvider, IDifferSyncProvider, IDifferParserProvider
    {

    }
}
