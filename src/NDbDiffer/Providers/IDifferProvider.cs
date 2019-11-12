namespace NDbDiffer.Providers
{
    public interface IDifferProvider : IDifferExtractProvider, IDifferSyncProvider, IDifferParserProvider, IDifferCompareProvider
    {

    }
}
