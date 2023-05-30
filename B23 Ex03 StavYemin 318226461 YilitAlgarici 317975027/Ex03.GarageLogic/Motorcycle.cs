using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Motorcycle : Vehicle
    {
        private int EngineCapacity;
        private eLicenseType m_LicenseType;

        private enum eLicenseType
        {
            A1,
            A2,
            AA,
            B1
        }
    }
}
