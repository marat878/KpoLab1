using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public class MockDataHelpersFactory : IDataHelpersFactory
    {
        public IDataProvider GetDataProvider()
        {
            return new MockMetalViscosityDataProvider();
        }

        public IDataSaver GetDataSaver()
        {
            return new MockMetalViscositySaver();
        }
    }
}
