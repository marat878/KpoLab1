using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KpoLab.Lib
{
    public class MetalViscositySaver : IDataSaver
    {
        private SaveStatus _Status = SaveStatus.None;
        public SaveStatus GetStatus()
        {
            return _Status;
        }

        public void Save(List<MetalViscosity> dataItems)
        {
            if (string.IsNullOrWhiteSpace(AppGlobalSettings.DataFileName))
            {
                _Status = SaveStatus.FileNameIsEmpty;
                throw new Exception("Не указано имя файла в файле конфигурации!");
            }

            if (!File.Exists(AppGlobalSettings.DataFileName))
            {
                _Status = SaveStatus.FileDoesNotExist;     
                throw new FileNotFoundException(AppGlobalSettings.DataFileName);
            }

            using (var writer = File.CreateText(AppGlobalSettings.DataFileName))
            {
                foreach (MetalViscosity item in dataItems)
                {
                    try
                    {
                        writer.WriteLine(string.Format("{0};{1};{2};{3}", item.Name, item.AtomicNumber, item.Temperature, item.Viscosity));
                    }
                    catch (Exception ex)
                    {
                        _Status = SaveStatus.GenericError;
                        LogHelper.ErrorLog(ex);
                    }
                }
            }

            if (_Status == SaveStatus.None)
            {
                _Status = SaveStatus.Successful;
            }            
        }
    }
}
