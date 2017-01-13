using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileDoesNotExist = -2,
        GenericError = -100
    }

    public interface IDataProvider
    {
        LoadStatus GetStatus();
        List<MetalViscosity> GetDataList();

        void Execute();
    }
}
