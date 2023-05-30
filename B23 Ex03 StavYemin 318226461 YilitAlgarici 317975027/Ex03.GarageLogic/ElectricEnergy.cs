namespace Ex03.GarageLogic
{
    internal class ElectricEnergy
    {
        private float m_RemainingBattryTime;
        private float m_MaximumBattryTime;
        
        private void fillBattery(float i_AmountToFill)
        {
            if (i_AmountToFill > 0 && (m_RemainingBattryTime + i_AmountToFill) <= m_MaximumBattryTime)
            {
                m_RemainingBattryTime += i_AmountToFill;
            }
            else
            {
                throw ValueOutOfRangeException;//
            }
        }
        
        private 
    }
}