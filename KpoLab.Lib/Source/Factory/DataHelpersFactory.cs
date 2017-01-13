using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public class DataHelpersFactory : IDataHelpersFactory
    {
        public IDataProvider GetDataProvider()
        {
            return new MetalViscosityDataProvider();
        }

        public IDataSaver GetDataSaver()
        {
            return new MetalViscositySaver();
        }
    }
}
