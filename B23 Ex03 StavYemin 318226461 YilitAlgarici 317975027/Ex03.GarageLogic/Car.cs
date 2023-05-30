using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Car : Vehicle
    {
        private eColor m_Color;
        private eNumOfDoors m_NumOfDoors;

        private enum eColor
        {
            White,
            Black,
            Yellow,
            Red
        }

        private enum eNumOfDoors
        {
            Two,
            Three,
            Four,
            Five
        }
    }
}
