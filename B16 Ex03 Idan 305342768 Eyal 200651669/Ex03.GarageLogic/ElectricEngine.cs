namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        private float m_ChargeTimeLeft;
        private float m_MaxChargeTime;

        public ElectricEngine(float i_ChargeTimeLeft, float i_MaxChargeTime)
        {
            this.m_ChargeTimeLeft = i_ChargeTimeLeft;
            this.m_MaxChargeTime = i_MaxChargeTime;
        }

        public override void RePower(float powerAmount)
        {
            float powerGivenToFuel = powerAmount + m_ChargeTimeLeft;
            this.m_ChargeTimeLeft = powerGivenToFuel > this.m_MaxChargeTime ? powerGivenToFuel : this.m_MaxChargeTime;
        }
    }
}
