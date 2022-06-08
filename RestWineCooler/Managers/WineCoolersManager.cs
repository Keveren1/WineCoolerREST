using System.Collections.Generic;
using WineCoolerLib;

namespace RestWineCooler.Managers
{
    public class WineCoolersManager
    {
        private static int nextId = 1;
        private static List<Cooler> data = new List<Cooler>()
        {
            new Cooler() {CoolerId = nextId++, CapacityOfBottles = 4, Temp = 10,BottlesInStorage = 3},
            new Cooler() {CoolerId = nextId++, CapacityOfBottles = 12, Temp = 11,BottlesInStorage = 10},
            new Cooler() {CoolerId = nextId++, CapacityOfBottles = 30, Temp = 5,BottlesInStorage = 22},
            new Cooler() {CoolerId = nextId++, CapacityOfBottles = 48, Temp = 4,BottlesInStorage = 48},
        };

        public List<Cooler> GetAll()
        {
            List<Cooler> result = new List<Cooler>(data);

            return result;
        }

        public Cooler GetById(int id)
        {
            return data.Find(cooler => cooler.CoolerId == id);
        }

        public Cooler AddNewCooler(Cooler newCooler)
        {
            newCooler.CoolerId = nextId++;
            data.Add(newCooler);
            return newCooler;
        }

        public Cooler DeleteCooler(int id)
        {
            Cooler cooler = data.Find(cooler => cooler.CoolerId == id);
            if (cooler == null) return null;
            data.Remove(cooler);
            return cooler;
        }

    }
}
