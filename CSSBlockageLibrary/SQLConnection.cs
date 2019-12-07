using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary
{
    public class SQLConnection : IDataConnection
    {
        public BlockEntryModel SaveEntry(BlockEntryModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
