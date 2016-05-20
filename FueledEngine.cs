namespace Ex03.GarageLogic
{
    public class FueledEngine : Engine
    {
        public enum eFuelType
        {
            Octan96,
            Octan95,
            Octan98,
            Soler
        }

        private readonly float r_MaxChargeTime;
        private float m_ChargeTimeLeft;

        public FueledEngine(float i_ChargeTimeLeft, float i_MaxChargeTime)
        {
            this.m_ChargeTimeLeft = i_ChargeTimeLeft;
            this.r_MaxChargeTime = i_ChargeTimeLeft;
        }

        public override void RePower(float i_ChargeTime)
        {
            if (i_ChargeTime + m_ChargeTimeLeft > r_MaxChargeTime)
            {
                throw new Exception;
            }
            else
            {
                m_ChargeTimeLeft += i_ChargeTime;
            }
        }
    }
}