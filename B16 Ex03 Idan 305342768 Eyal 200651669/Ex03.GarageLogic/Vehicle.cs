using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private string m_ModelType;

        private string m_LicensePlate;

        private float m_EnergyPrecentageLeft;

        public List<Wheel> m_Wheels;

        public string GetModelType()
        {
            return m_ModelType;
        }

        public string GetLicensePlatel()
        {
            return m_LicensePlate;
        }

        public float GetEnergyPrecentageLeft()
        {
            return m_EnergyPrecentageLeft;
        }

        public List<Wheel> GetWheels()
        {
            return m_Wheels;
        }
    }
}
