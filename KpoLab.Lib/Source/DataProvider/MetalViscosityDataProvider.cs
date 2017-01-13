using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KpoLab.Lib
{
    public class MetalViscosityDataProvider : IDataProvider
    {
        private LoadStatus _Status = LoadStatus.None;
        public LoadStatus GetStatus()
        {
            return _Status;
        }

        private List<MetalViscosity> _DataList = null;
        public List<MetalViscosity> GetDataList()
        {
            return _DataList;
        }

        public MetalViscosityDataProvider()
        {
            _DataList = new List<MetalViscosity>();
        }

        private void ParseLine(string source)
        {
            try
            {
                MetalViscosity item = new MetalViscosity();
                string[] parts = source.Split(';');
                item.Name = parts[0];
                item.AtomicNumber = Int32.Parse(parts[1]);
                item.Temperature = Int32.Parse(parts[2]);
                item.Viscosity = Double.Parse(parts[3], System.Globalization.CultureInfo.InvariantCulture);
                _DataList.Add(item);
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex);
                _Status = LoadStatus.GenericError;
            }
        }

        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(AppGlobalSettings.DataFileName))
            {
                _Status = LoadStatus.FileNameIsEmpty;
                throw new Exception("Не указано имя файла в файле конфигурации!");
            }

            if (!File.Exists(AppGlobalSettings.DataFileName))
            {
                _Status = LoadStatus.FileDoesNotExist;
                _DataList = null;
                throw new FileNotFoundException(AppGlobalSettings.DataFileName);
            }

            using (var reader = File.OpenText(AppGlobalSettings.DataFileName))
            {
                while (!reader.EndOfStream)
                {
                    ParseLine(reader.ReadLine());
                }
            }

            if (_Status == LoadStatus.None)
            {
                _Status = LoadStatus.Success;
            }
        }
    }
}
