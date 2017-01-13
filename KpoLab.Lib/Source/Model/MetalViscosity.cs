using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public class MetalViscosity
    {
        /// <summary>
        /// Вещество
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Атомный номер
        /// </summary>
        public Int32 AtomicNumber { get; set; }

        /// <summary>
        /// Температура (С)
        /// </summary>
        public Int32 Temperature { get; set; }

        /// <summary>
        /// Вязкость (кг/м*сек)
        /// </summary>
        public double Viscosity { get; set; }

        public MetalViscosity()
        {
            Name = "";
            AtomicNumber = 0;
            Temperature = 0;
            Viscosity = 0.0;
        }
    }
}
