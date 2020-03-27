
using System;

namespace SingletonVsFactory
{
    public class ElectricKettle
    {
        private static ElectricKettle _electricKettle;
        private static ElectricKettleStatus _status;
        private static string _msg;
        private ElectricKettle()
        {
            _status = ElectricKettleStatus.Empty;
            _msg = "Starting";
        }

        public static ElectricKettle GetSingleton()
        {
            if (_electricKettle == null)
            {
               return  new ElectricKettle();
            }

            return _electricKettle;
        }

        public Tuple<string, ElectricKettleStatus> GetState()
        {
            return Tuple.Create(_msg, _status);
        }
        public void Fill()
        {
            if (_status != ElectricKettleStatus.Empty) return;
            _msg = "Filling...";
            _status = ElectricKettleStatus.InProgress;


        }
        public void Boil()
        {
            _msg = "Boiling...";
            _status = ElectricKettleStatus.Boiled;
        }

        public void Drain()
        {
            _msg = "Draining...";
            _status = ElectricKettleStatus.Empty;
        }
        
    }
    public enum ElectricKettleStatus
    {
        Empty, InProgress, Boiled
    }
}
