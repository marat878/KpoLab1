using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public class MockMetalViscosityDataProvider
    {
        private readonly string _DataFileName = "";

        private List<MetalViscosity> _DataList = null;
        public List<MetalViscosity> DataList
        {
            get 
            {
                return _DataList;
            }
        }

        public MockMetalViscosityDataProvider()
        {
            _DataList = new List<MetalViscosity>();
        }

        public void Execute()
        {
            _DataList.Add(new MetalViscosity()
            {
                Name = "Алюминий",
                AtomicNumber = 13,
                Temperature = 700,
                Viscosity = 2.9
            });

            _DataList.Add(new MetalViscosity()
            {
                Name = "Висмут",
                AtomicNumber = 83,
                Temperature = 304,
                Viscosity = 1.65
            });

            _DataList.Add(new MetalViscosity()
            {
                Name = "Свинец",
                AtomicNumber = 82,
                Temperature = 441,
                Viscosity = 2.11
            });
        }
    }
}
