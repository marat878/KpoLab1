using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public interface IDataHelpersFactory
    {
        IDataProvider GetDataProvider();
        IDataSaver GetDataSaver();
    }
}
