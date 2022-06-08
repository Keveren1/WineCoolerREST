using System;

namespace WineCoolerLib
{
    public class Cooler
    {
        
        private int _BottlesInStorage;
        public int CoolerId { get; set; }
        public int CapacityOfBottles
        { get; set; }
        public int Temp { get; set; }
        public int BottlesInStorage
        {
            get => _BottlesInStorage;
            set
            {
                if (value < 0 || value > CapacityOfBottles) throw new ArgumentOutOfRangeException("Hvad du lave her?");
                _BottlesInStorage = value;
            }
        }

        public Cooler(int coolerId, int capacityOfBottles, int temp, int bottlesInStorage)
        {
            CoolerId = coolerId;
            CapacityOfBottles = capacityOfBottles;
            Temp = temp;
            BottlesInStorage = bottlesInStorage;
        }

        public Cooler()
        {

        }

        public bool CoolerIsFull()
        {
            if (CapacityOfBottles == BottlesInStorage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddWine()
        {
            if (BottlesInStorage==CapacityOfBottles)
            {
                throw new ArgumentOutOfRangeException("Max Capacity");
            }
            else
            {
                return BottlesInStorage++;
            }
        }
    }
}
