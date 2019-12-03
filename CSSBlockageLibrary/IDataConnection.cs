using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary
{
    public interface IDataConnection
    {
        BlockEntryModel SaveEntry(BlockEntryModel model);

    }
}
