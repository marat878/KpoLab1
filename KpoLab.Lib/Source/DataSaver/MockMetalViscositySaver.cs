using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public class MockMetalViscositySaver : IDataSaver
    {
        private SaveStatus _Status = SaveStatus.None;
        public SaveStatus GetStatus()
        {
            return _Status;
        }

        public void Save(List<MetalViscosity> dataItems)
        {
            // ничего не делаем, метод-заглушка
            _Status = SaveStatus.Successful;
        }
    }
}
