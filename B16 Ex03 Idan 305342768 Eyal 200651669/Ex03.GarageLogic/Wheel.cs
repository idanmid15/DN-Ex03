namespace Ex03.GarageLogic
{
using System;
using System.Collections.Generic;
using System.Text;

    public class Wheel
    {
        private readonly float r_MaxTirePressure;
        public string m_Manufacturer;

        private float m_CurrentTirePressure;

        public float GetMaxTirePressure()
        {
            return r_MaxTirePressure;
        }
        
        public string GetManufacturer()
        {
            return m_Manufacturer;
        }

        public float GetCurrentTirePressure()
        {
            return m_CurrentTirePressure;
        }

        public void SetTirePressure(float i_TirePressure)
        {
            this.m_CurrentTirePressure = i_TirePressure;
        }

        public Wheel(string i_Manufacturer, float i_TirePressure, int i_MaxTirePressure)
        {
            this.m_Manufacturer = i_Manufacturer;
            this.m_CurrentTirePressure = i_TirePressure;
            this.r_MaxTirePressure = i_MaxTirePressure;
        }
    }
}
