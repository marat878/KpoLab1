using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpoLab.Lib
{
    public static class MetalViscosityHelper
    {
        public static bool ValidateFields(MetalViscosity target)
        {
            if (string.IsNullOrWhiteSpace(target.Name) || target.Name.Length > 32)
            {
                return false;
            }

            if (target.AtomicNumber < 0)
            {
                return false;
            }

            if (target.Temperature < -273)
            {
                return false;
            }

            return true;
        }
    }
}
