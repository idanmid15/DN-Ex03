﻿namespace Ex03.GarageLogic
{
    public class FueledcBike : Bike
    {
        private const float k_MaxFueledEngine = 7.2f;

        public FueledcBike
            (string i_ModelType,
            string i_LicensePlate,
            string i_WheelManufacturer,
            float[] i_TirePressures,
            FueledEngine.eFuelType i_FuelType,
            float i_CurrentFuelAmount)
        {
            this.m_ModelType = i_ModelType;
            this.m_LicensePlate = i_LicensePlate;
            this.m_Wheels.Add(new Wheel(i_WheelManufacturer, i_TirePressures[0], k_MaxTirePressure));
            this.m_Wheels.Add(new Wheel(i_WheelManufacturer, i_TirePressures[1], k_MaxTirePressure));
            this.m_Engine = new FueledEngine(i_CurrentFuelAmount, k_MaxFueledEngine, FueledEngine.eFuelType.Octan95);
            this.m_EnergyPrecentageLeft = i_CurrentFuelAmount / k_MaxFueledEngine;
        }
    }
}