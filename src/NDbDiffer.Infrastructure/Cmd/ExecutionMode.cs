using System;

namespace NDbDiffer.Infrastructure.Cmd
{
    [Flags]
    public enum ExecutionMode
    {
        Extract,
        Sync
    }
}