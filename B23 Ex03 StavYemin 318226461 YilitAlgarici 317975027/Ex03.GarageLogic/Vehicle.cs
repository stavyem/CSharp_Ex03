using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Vehicle
    {
        private string m_Model;
        private string m_LicenceNum;
        private float m_EnergyPercentage;
        private list<wheel> m_WheelCollection;
        private EnergySource m_EnergySource;


    }
}
