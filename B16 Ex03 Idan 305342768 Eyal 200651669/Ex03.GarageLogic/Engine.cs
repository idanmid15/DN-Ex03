using System;

namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        public enum eEngineType
        {
            fuel,
            electric,
            other
        }

        public abstract void rePower(float powerAmount);
    }
}
