using System;

namespace Ex03.GarageLogic
{
    public class Bike : Vehicle
    {
        public enum eLicensePlate
        {
            A,
            A1,
            AB,
            B1
        }

        private eLicensePlate m_licenseType;
        private int m_EngineVolume;
    }
}
