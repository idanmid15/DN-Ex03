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

        private enum m_EngineType
        {
            get,
        }

        public abstract void RePower(float powerAmount);
    }
}
