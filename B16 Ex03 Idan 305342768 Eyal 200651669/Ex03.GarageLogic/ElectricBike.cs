
namespace Ex03.GarageLogic
{
    public class ElectricBike : Bike
    {
        public ElectricBike
            (string i_ModelType,
            string i_LicensePlate,
            string i_WheelManufacturer,
            float[] i_TirePressures,
            float i_ChargeTimeLeft,
            float i_MaxChargeTime)
        {
            this.m_ModelType = i_ModelType;
            this.m_LicensePlate = i_LicensePlate;
            this.m_Wheels.Add(new Wheel(i_WheelManufacturer, i_TirePressures[0], k_MaxTirePressure));
            this.m_Wheels.Add(new Wheel(i_WheelManufacturer, i_TirePressures[1], k_MaxTirePressure));
            this.m_Engine = new ElectricEngine(i_ChargeTimeLeft, i_MaxChargeTime);


        }
    }
}
