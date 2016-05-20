namespace Ex03.GarageLogic
{
using System;
using System.Collections.Generic;
using System.Text;

    public class Wheel
    {
        private string m_Manufacturer { get; }

        private float m_CurrentTirePressure { get; set; }

        private readonly float r_MaxTirePressure;

        public float getMaxTirePressure()
        {
            return r_MaxTirePressure;
        }
        
        public Wheel(string i_Manufacturer, float i_TirePressure, int i_MaxTirePressure)
        {
            this.m_Manufacturer = i_Manufacturer;
            this.m_CurrentTirePressure = i_TirePressure;
            this.r_MaxTirePressure = i_MaxTirePressure;
        }
    }
}
