using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private string m_ModelType { get; }

        private string m_LicensePlate { get; }

        private float m_EnergyPrecentageLeft { get; set; }

        public List<Wheel> m_Wheels { get; }
    }
}
