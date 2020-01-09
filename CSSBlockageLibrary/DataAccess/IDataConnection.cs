using CSSBlockageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary.DataAccess
{
    public interface IDataConnection
    {
        BlockEntryModel SaveEntry(BlockEntryModel model);

        //BlockEntryModel PullEntry(int entryId);

    }
}
