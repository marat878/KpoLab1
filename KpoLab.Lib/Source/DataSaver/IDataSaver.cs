using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public enum SaveStatus
    {
        None = 0,
        Successful = 1,
        FileNameIsEmpty = -1,
        FileDoesNotExist = -2,
        GenericError = -100        
    }

    public interface IDataSaver
    {
        SaveStatus GetStatus();
        void Save(List<MetalViscosity> dataList);
    }
}
